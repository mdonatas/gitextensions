using System;

namespace GitUI.HelperDialogs
{
    public sealed partial class FormCommitDiff : GitModuleForm
    {
        private FormCommitDiff(GitUICommands aCommands)
            : base(aCommands)
        {
            InitializeComponent();
            Translate();
        }

        private FormCommitDiff()
            : this(null)
        {
        }

        public FormCommitDiff(GitUICommands aCommands, string revision)
            : this(aCommands)
        {
            CommitDiff.TextChanged += CommitDiff_TextChanged;
            CommitDiff.SetRevision(revision, null);
        }

        private void CommitDiff_TextChanged(object sender, EventArgs e)
        {
            Text = CommitDiff.Text;
        }
    }
}
