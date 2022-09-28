using System;
using System.ComponentModel.Composition;
using System.IO;
using System.IO.IsolatedStorage;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GitCommands.Config;
using GitUI.HelperDialogs;
using GitUIPluginInterfaces;
using GitUIPluginInterfaces.BuildServerIntegration;

namespace GitUI.BuildServerIntegration
{
    [Export(typeof(IBuildServerCredentialStore))]
    public class BuildServerCredentialStore : IBuildServerCredentialStore
    {
        private readonly object _buildServerCredentialsLock = new();

        public IBuildServerCredentials? GetBuildServerCredentials(Control uiControl, IBuildServerAdapter buildServerAdapter, bool useStoredCredentialsIfExisting)
        {
            lock (_buildServerCredentialsLock)
            {
                IBuildServerCredentials? buildServerCredentials = new BuildServerCredentials { BuildServerCredentialsType = BuildServerCredentialsType.Guest };
                bool foundInConfig = false;

                const string CredentialsConfigName = "Credentials";
                const string UseGuestAccessKey = "UseGuestAccess";
                const string BuildServerCredentialsTypeKey = "BuildServerCredentialsType";
                const string UsernameKey = "Username";
                const string PasswordKey = "Password";
                const string BearerTokenKey = "BearerToken";
                using (var stream = GetBuildServerOptionsIsolatedStorageStream(buildServerAdapter, FileAccess.Read, FileShare.Read))
                {
                    if (stream.Position < stream.Length)
                    {
                        var protectedData = new byte[stream.Length];

                        stream.Read(protectedData, 0, (int)stream.Length);
                        try
                        {
                            byte[] unprotectedData = ProtectedData.Unprotect(protectedData, null,
                                DataProtectionScope.CurrentUser);
                            using MemoryStream memoryStream = new(unprotectedData);
                            ConfigFile credentialsConfig = new("", false);

                            using (StreamReader textReader = new(memoryStream, Encoding.UTF8))
                            {
                                credentialsConfig.LoadFromString(textReader.ReadToEnd());
                            }

                            var section = credentialsConfig.FindConfigSection(CredentialsConfigName);

                            if (section is not null)
                            {
                                string? buildServerCredentialsType = section.GetValue(BuildServerCredentialsTypeKey);
                                if (!string.IsNullOrWhiteSpace(buildServerCredentialsType))
                                {
                                    buildServerCredentials.BuildServerCredentialsType = Enum.Parse<BuildServerCredentialsType>(buildServerCredentialsType);
                                }
                                else
                                {
                                    buildServerCredentials.BuildServerCredentialsType =
                                        section.GetValueAsBool(UseGuestAccessKey, true)
                                            ? BuildServerCredentialsType.Guest
                                            : BuildServerCredentialsType.UsernameAndPassword;
                                }

                                buildServerCredentials.Username = section.GetValue(UsernameKey);
                                buildServerCredentials.Password = section.GetValue(PasswordKey);
                                buildServerCredentials.BearerToken = section.GetValue(BearerTokenKey);
                                foundInConfig = true;

                                if (useStoredCredentialsIfExisting)
                                {
                                    return buildServerCredentials;
                                }
                            }
                        }
                        catch (CryptographicException)
                        {
                            // As per MSDN, the ProtectedData.Unprotect method is per user,
                            // it will throw the CryptographicException if the current user
                            // is not the one who protected the data.

                            // Set this variable to false so the user can reset the credentials.
                            useStoredCredentialsIfExisting = false;
                        }
                    }
                }

                if (!useStoredCredentialsIfExisting || !foundInConfig)
                {
                    buildServerCredentials = ThreadHelper.JoinableTaskFactory.Run(() => ShowBuildServerCredentialsFormAsync(uiControl, buildServerAdapter.UniqueKey, buildServerCredentials));

                    if (buildServerCredentials is not null)
                    {
                        ConfigFile credentialsConfig = new("", true);

                        var section = credentialsConfig.FindOrCreateConfigSection(CredentialsConfigName);

                        section.SetValue(BuildServerCredentialsTypeKey, buildServerCredentials.BuildServerCredentialsType.ToString());
                        section.SetValue(UsernameKey, buildServerCredentials.Username);
                        section.SetValue(PasswordKey, buildServerCredentials.Password);
                        section.SetValue(BearerTokenKey, buildServerCredentials.BearerToken);

                        using var stream = GetBuildServerOptionsIsolatedStorageStream(buildServerAdapter, FileAccess.Write, FileShare.None);
                        using MemoryStream memoryStream = new();
                        using (StreamWriter textWriter = new(memoryStream, Encoding.UTF8))
                        {
                            textWriter.Write(credentialsConfig.GetAsString());
                        }

                        var protectedData = ProtectedData.Protect(memoryStream.ToArray(), null, DataProtectionScope.CurrentUser);
                        stream.Write(protectedData, 0, protectedData.Length);

                        return buildServerCredentials;
                    }
                }

                return null;
            }
        }

        private async Task<IBuildServerCredentials?> ShowBuildServerCredentialsFormAsync(Control uiControl, string buildServerUniqueKey, IBuildServerCredentials buildServerCredentials)
        {
            await uiControl.SwitchToMainThreadAsync();

            using FormBuildServerCredentials form = new(buildServerUniqueKey);
            form.BuildServerCredentials = buildServerCredentials;

            if (form.ShowDialog(uiControl) == DialogResult.OK)
            {
                return buildServerCredentials;
            }

            return null;
        }

        private static IsolatedStorageFileStream GetBuildServerOptionsIsolatedStorageStream(IBuildServerAdapter buildServerAdapter, FileAccess fileAccess, FileShare fileShare)
        {
            var fileName = string.Format("BuildServer-{0}.options", Convert.ToBase64String(Encoding.UTF8.GetBytes(buildServerAdapter.UniqueKey)));
            return new IsolatedStorageFileStream(fileName, FileMode.OpenOrCreate, fileAccess, fileShare);
        }
    }
}
