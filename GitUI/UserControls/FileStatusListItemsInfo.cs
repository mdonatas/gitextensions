using GitCommands;

namespace GitUI
{
    public class FileStatusListItemsInfo
    {
        public FileStatusListItemsInfo(string groupName, GitRevision parentRevision, GitRevision revision, ListType itemsType = ListType.SimpleRevision)
        {
            GroupName = groupName;
            Revision = revision;
            ParentRevision = parentRevision;
            Type = itemsType;
        }

        public string GroupName { get; }
        public GitRevision Revision { get; }
        public GitRevision ParentRevision { get; }
        public ListType Type { get; }

        public enum ListType
        {
            SimpleRevision = 0,
            CombinedDiff = 1, // Used in a merge commit
            BaseToADiff = 2,
            BaseToBDiff = 3,
            CommonFilesDiff = 4
        }
    }
}
