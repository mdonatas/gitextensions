using System;

namespace GitUIPluginInterfaces;

public interface IRepoNameExtractor
{
    IRepoNameExtractor Create(Func<IGitModule> getModule);

    /// <summary>
    /// Get a "repo shortname" from the current repo URL
    /// There is no official Git repo shortname, this is one possible definition:
    ///  The filename without extension for the remote URL
    /// This function could have been included in GitModule
    /// </summary>
    (string repoProject, string repoName) Get();
}
