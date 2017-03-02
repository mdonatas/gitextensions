using System;
using System.Windows.Forms;
using GitCommands;
using ResourceManager;

namespace GitUI.HelperDialogs
{
    public partial class FormResetBranch : GitModuleForm
    {
        private readonly TranslationString _branchInfo = new TranslationString("Reset branch '{0}' to revision:");

        [Obsolete("For VS designer and translation test only. Do not remove.")]
        private FormResetBranch()
        {
            InitializeComponent();
        }

        public FormResetBranch(GitUICommands commands, GitRevision revision, GitRef gitReference)
            : base(commands)
        {
            Revision = revision;
            GitReference = gitReference;

            InitializeComponent();
            InitializeComplete();
        }

        public GitRevision Revision { get; set; }
        public GitRef GitReference { get; set; }

        private void FormResetBranch_Load(object sender, EventArgs e)
        {
            if (Revision == null)
            {
                throw new Exception("No revision");
            }

            if (GitReference.IsTag || (!GitReference.IsHead && !GitReference.IsRemote && !GitReference.IsTag) || GitReference.IsRemote)
            {
                throw new Exception("Invalid GitRef. Branch expected.");
            }

            _NO_TRANSLATE_BranchInfo.Text = string.Format(_branchInfo.Text, GitReference.Name);
            commitSummaryUserControl1.Revision = Revision;
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            FormProcess.ShowDialog(this, GitCommandHelpers.PushLocalCmd(GitReference.CompleteName, Revision.Guid, ForceReset.Checked));

            UICommands.RepoChangedNotifier.Notify();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
