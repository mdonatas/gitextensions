namespace GitUI
{
    public class FileStatusListItemsInfo
    {
        public FileStatusListItemsInfo(string groupName, string parentRevisionGuid, ListType itemsType = ListType.SimpleRevision)
            : this(groupName, parentRevisionGuid, null, itemsType)
        {
        }

        public FileStatusListItemsInfo(string groupName, string parentRevisionGuid, string revisionGuid, ListType itemsType = ListType.SimpleRevision)
        {
            GroupName = groupName;
            RevisionGuid = revisionGuid;
            ParentRevisionGuid = parentRevisionGuid;
            Type = itemsType;
        }

        public string GroupName { get; private set; }
        public string RevisionGuid { get; private set; }
        public string ParentRevisionGuid { get; private set; }
        public ListType Type { get; private set; }

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
