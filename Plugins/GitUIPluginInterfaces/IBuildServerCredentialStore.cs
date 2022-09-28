using System.Windows.Forms;
using GitUIPluginInterfaces.BuildServerIntegration;

namespace GitUIPluginInterfaces;

public interface IBuildServerCredentialStore
{
    IBuildServerCredentials? GetBuildServerCredentials(Control uiControl, IBuildServerAdapter buildServerAdapter, bool useStoredCredentialsIfExisting);
}
