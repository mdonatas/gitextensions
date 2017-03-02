using System.Collections.Generic;

namespace GitCommands
{
    public class GitItemStatusNameEqualityComparer : IEqualityComparer<GitItemStatus>
    {
        public bool Equals(GitItemStatus itemA, GitItemStatus itemB)
        {
            bool result;

            if (string.IsNullOrWhiteSpace(itemA.Name) && string.IsNullOrWhiteSpace(itemB.Name))
            {
                result = true;
            }
            else
            {
                result = itemA.Name == itemB.Name;
                if (result)
                {
                    result = itemA.OldName == itemB.OldName;
                }
            }

            return result;
        }

        public int GetHashCode(GitItemStatus item)
        {
            unchecked
            {
                return ((item.Name != null ? item.Name.GetHashCode() : 0) * 397) ^
                        (item.OldName != null ? item.OldName.GetHashCode() : 0);
            }
        }

        private static GitItemStatusNameEqualityComparer _instance;
        public static GitItemStatusNameEqualityComparer Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new GitItemStatusNameEqualityComparer();
                }

                return _instance;
            }
        }
    }
}
