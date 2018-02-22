using System;
using System.Linq;
using System.Windows.Forms;
using GitCommands;

namespace GitUI.UserControls
{
    public partial class CommitDiff : GitModuleControl
    {
        private GitRevision _revision;

        public CommitDiff()
        {
            InitializeComponent();
            Translate();
            DiffText.ExtraDiffArgumentsChanged += DiffText_ExtraDiffArgumentsChanged;
            DiffFiles.Focus();
            DiffFiles.GitItemStatuses = null;
        }

        public void SetRevision(string revision, string fileToSelect)
        {
            //We cannot use the GitRevision from revision grid. When a filtered commit list
            //is shown (file history/normal filter) the parent guids are not the 'real' parents,
            //but the parents in the filtered list.
            _revision = Module.GetRevision(revision);

            if (_revision != null)
            {
                DiffFiles.SetDiff(_revision);
                if (fileToSelect != null)
                {
                    var itemToSelect = DiffFiles.AllItems.FirstOrDefault(i => i.Name == fileToSelect);
                    if (itemToSelect != null)
                    {
                        DiffFiles.SelectedItem = itemToSelect;
                    }
                }

                commitInfo.Revision = _revision;

                Text = "Diff - " + GitRevision.ToShortSha(_revision.Guid) + " - " + _revision.AuthorDate + " - " + _revision.Author + " - " + Module.WorkingDir;
            }
        }

        private void DiffFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            ViewSelectedDiff();
        }

        void DiffText_ExtraDiffArgumentsChanged(object sender, EventArgs e)
        {
            ViewSelectedDiff();
        }

        private void ViewSelectedDiff()
        {
            if (DiffFiles.SelectedItem != null && _revision != null)
            {
                Cursor.Current = Cursors.WaitCursor;
                DiffText.ViewChanges(DiffFiles.SelectedItemParent, _revision.Guid, DiffFiles.SelectedItem, string.Empty);
                Cursor.Current = Cursors.Default;
            }
        }
    }
}
