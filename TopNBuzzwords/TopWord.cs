using System;
using System.Collections.Generic;

namespace TopNBuzzwords
{
    public class TopWord
    {
        public string word;
        public int count;
        public HashSet<int> quotaIds;
        public TopWord(string word, int count)
        {
            this.word = word;
            this.count = count;
            quotaIds = new HashSet<int>();

        }
        public class WordComparer : IComparer<TopWord>
        {
            int IComparer<TopWord>.Compare(TopWord one, TopWord two)
            {
                if (one.count != two.count)
                {
                    return two.count.CompareTo(one.count);
                }

                if (one.GetCount() != two.GetCount())
                {
                    return two.GetCount().CompareTo(one.GetCount());
                }
                return string.Compare(two.word, one.word, StringComparison.Ordinal);
            }
        }
        public int GetCount()
        {
            return this.quotaIds.Count;
        }
    }
}