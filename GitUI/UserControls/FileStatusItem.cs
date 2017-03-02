using GitCommands;
using GitUIPluginInterfaces;

namespace GitUI
{
    public class FileStatusItem
    {
        public FileStatusItem(GitItemStatus gitItemStatus, GitRevision revision, GitRevision parentRevision)
        {
            GitItemStatus = gitItemStatus;
            Revision = revision;
            ParentRevision = parentRevision;
        }

        public GitRevision Revision { get; }
        public GitRevision ParentRevision { get; }

        public GitItemStatus GitItemStatus { get; }

        public string Name => GitItemStatus.Name;
        public string OldName => GitItemStatus.OldName;
        public ObjectId TreeGuid => GitItemStatus.TreeGuid;
        public bool IsNew => GitItemStatus.IsNew;
        public bool IsTracked => GitItemStatus.IsTracked;
        public StagedStatus Staged => GitItemStatus.Staged;
        public bool IsDeleted => GitItemStatus.IsDeleted;
        public bool IsRenamed => GitItemStatus.IsRenamed;
        public bool IsSubmodule => GitItemStatus.IsSubmodule;
        public bool IsAssumeUnchanged => GitItemStatus.IsAssumeUnchanged;
        public bool IsSkipWorktree => GitItemStatus.IsSkipWorktree;

        public override string ToString()
        {
            return GitItemStatus.ToString();
        }

        public static implicit operator GitItemStatus(FileStatusItem fsi)
        {
            return fsi?.GitItemStatus;
        }
    }
}
