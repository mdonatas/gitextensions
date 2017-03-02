using GitCommands;
using ResourceManager;
using System;

namespace GitUI.HelperDialogs
{
    public partial class FormResetBranch : GitModuleForm
    {
        readonly TranslationString branchInfo = new TranslationString("Reset branch '{0}' to revision:");

        public FormResetBranch(GitUICommands aCommands, GitRevision revision, GitRef gitReference)
            : base(aCommands)
        {
            Revision = revision;
            GitReference = gitReference;

            InitializeComponent(); Translate();
        }

        public GitRevision Revision { get; set; }
        public GitRef GitReference { get; set; }

        private void FormResetBranch_Load(object sender, EventArgs e)
        {
            if (Revision == null)
                throw new Exception("No revision");

            if (GitReference.IsTag || GitReference.IsOther || GitReference.IsRemote)
                throw new Exception("Invalid GitRef. Branch expected.");

            _NO_TRANSLATE_BranchInfo.Text = string.Format(branchInfo.Text, GitReference.Name);
            commitSummaryUserControl1.Revision = Revision;
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            FormProcess.ShowDialog(this, GitCommandHelpers.PushLocalCmd(GitReference.CompleteName, Revision.Guid, ForceReset.Checked));

            UICommands.RepoChangedNotifier.Notify();
            Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
