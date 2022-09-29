using System.Collections.Generic;
using System.Windows.Forms;

namespace GitUIPluginInterfaces.BuildServerIntegration
{
    public interface IBuildServerSettingsUserControl
    {
        void Initialize(string defaultProjectName, IEnumerable<string?> remotes, IGitUICommands gitUiCommands);

        void LoadSettings(ISettingsSource buildServerConfig);
        void SaveSettings(ISettingsSource buildServerConfig);
        void OpenCredentialsForm(Control uiControl, IBuildServerSettings buildServerSettings);
    }
}
