using GitExtensions.Extensibility;
using GitExtensions.Extensibility.Git;
using GitExtUtils;

namespace GitCommands
{
    public static class FileHelper
    {
        private static readonly IEnumerable<string> BinaryExtensions = new[]
        {
            ".avi", // movie
            ".bmp", // image
            ".dat", // data file
            ".bin", // binary file
            ".dll", // dynamic link library
            ".doc", // office word
            ".docx", // office word
            ".ppt", // office powerpoint
            ".pps", // office powerpoint
            ".pptx", // office powerpoint
            ".ppsx", // office powerpoint
            ".dwg", // autocad
            ".exe", // executable
            ".gif", // image
            ".ico", // icon
            ".jpg", // image
            ".jpeg", // image
            ".mpg", // movie
            ".mpeg", // movie
            ".msi", // installer
            ".pdf", // pdf document
            ".png", // image
            ".pdb", // debug file
            ".sc1", // screen file
            ".tif", // image
            ".tiff", // image
            ".vsd", // microsoft visio
            ".vsdx", // microsoft
            ".xls", // microsoft excel
            ".xlsx", // microsoft excel
            ".odt" // Open office
        };

        private static readonly IEnumerable<string> ImageExtensions = new[]
        {
            ".bmp",
            ".gif",
            ".ico",
            ".jpg",
            ".jpeg",
            ".png",
            ".tif",
            ".tiff",
        };

        public static bool IsBinaryFileName(IGitModule module, string? fileName)
        {
            return !string.IsNullOrWhiteSpace(fileName)
                   && (IsBinaryAccordingToGitAttributes(module, fileName)
                       ?? HasMatchingExtension(BinaryExtensions, fileName));
        }

        private static readonly HashSet<string>.AlternateLookup<ReadOnlySpan<char>> _diffModeLookup =
            new HashSet<string>(["set", "astextplain", "ada", "bibtext", "cpp", "csharp", "css", "dts", "elixir", "fortran", "html", "java", "kotlin", "markdown", "matlab", "objc", "pascal", "perl", "php", "python", "ruby", "rust", "scheme", "tex"], StringComparer.Ordinal)
            .GetAlternateLookup<ReadOnlySpan<char>>();

        /// <returns>null if no info in .gitattributes (or ambiguous). True if marked as binary, false if marked as text</returns>
        private static bool? IsBinaryAccordingToGitAttributes(IGitModule module, string fileName)
        {
            GitArgumentBuilder cmd = new("check-attr")
            {
                "-z",
                "diff",
                "text",
                "crlf",
                "eol",
                "--",
                fileName.Quote()
            };
            ExecutionResult result = module.GitExecutable.Execute(cmd, throwOnErrorExit: false);
            if (!result.ExitedSuccessfully)
            {
                return null;
            }

            ReadOnlySpan<char> span = result.StandardOutput.AsSpan();

            MemoryExtensions.SpanSplitEnumerator<char> enumerator = span.Split(Delimiters.Null);

            // diff
            MoveToNextValue(ref enumerator);
            ReadOnlySpan<char> value = span[enumerator.Current];

            if (value.SequenceEqual("unset"))
            {
                return true;
            }

            if (_diffModeLookup.Contains(value))
            {
                return false;
            }

            // text, crlf, eol
            while (MoveToNextValue(ref enumerator))
            {
                value = span[enumerator.Current];

                if (!value.SequenceEqual("unset") && !value.SequenceEqual("unspecified"))
                {
                    return false;
                }
            }

            return null;

            static bool MoveToNextValue(ref MemoryExtensions.SpanSplitEnumerator<char> enumerator)
            {
                enumerator.MoveNext();
                enumerator.MoveNext();
                return enumerator.MoveNext();
            }
        }

        public static bool IsImage(string fileName)
        {
            return HasMatchingExtension(ImageExtensions, fileName);
        }

        private static bool HasMatchingExtension(IEnumerable<string> extensions, string fileName)
        {
            return extensions.Any(extension => fileName.EndsWith(extension, StringComparison.CurrentCultureIgnoreCase));
        }

        #region binary file check

        public static bool IsBinaryFileAccordingToContent(byte[]? content)
        {
            // Check for binary file.
            if (content?.Length is > 0)
            {
                int nullCount = 0;
                foreach (char c in content)
                {
                    if (c == '\0')
                    {
                        nullCount++;
                    }

                    if (nullCount > 5)
                    {
                        break;
                    }
                }

                if (nullCount > 5)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool IsBinaryFileAccordingToContent(string? content)
        {
            // Check for binary file.
            if (!string.IsNullOrEmpty(content))
            {
                int nullCount = 0;
                foreach (char c in content)
                {
                    if (c == '\0')
                    {
                        nullCount++;
                        if (nullCount > 5)
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }

        #endregion
    }
}
