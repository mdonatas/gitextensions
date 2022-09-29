namespace GitUIPluginInterfaces.BuildServerIntegration;

public class BuildServerVariableReplacer
{
    private readonly IRepoNameExtractor _repoNameExtractor;

    public BuildServerVariableReplacer(IRepoNameExtractor repoNameExtractor)
    {
        _repoNameExtractor = repoNameExtractor;
    }

    /// <summary>
    /// Replace variables for the project string with the current "repo shortname"
    /// </summary>
    /// <param name="projectNames">build server specific format, compatible with the variable format</param>
    /// <returns>projectNames with variables replaced</returns>
    public string ReplaceVariables(string projectNames)
    {
        var (repoProject, repoName) = _repoNameExtractor.Get();

        if (!string.IsNullOrWhiteSpace(repoProject))
        {
            projectNames = projectNames.Replace("{cRepoProject}", repoProject);
        }

        if (!string.IsNullOrWhiteSpace(repoName))
        {
            projectNames = projectNames.Replace("{cRepoShortName}", repoName);
        }

        return projectNames;
    }
}
