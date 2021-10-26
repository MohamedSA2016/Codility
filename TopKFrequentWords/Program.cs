using System;
using System.Collections.Generic;
using System.Linq;

namespace TopKFrequentWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] word = { "i,love,leetcode,i,love,coding" };
            int k = ( 2 );
            Console.WriteLine( TopKFrequent(word,k));
        }

        private static IList<string> TopKFrequent(string[] word, int k)
        {
            Array.Sort(word);
            Dictionary<string, int> dict = new Dictionary<string, int>();
            var Lst = new List<string>();
            int maxfreq = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (dict.ContainsKey(word[i]))
                {
                    dict[word[i]]++;
                }
                else
                {
                    dict[word[i]] = 1;
                }
                if (dict[word[i]] > maxfreq)
                {
                    maxfreq = dict[word[i]];
                }
            }
            List<string> list = new List<string>();
            foreach (var lt in dict.OrderByDescending(i => i.Value))
            {
                if (list == null)
                {
                    list = new List<string>();
                }
                list.Add(lt.Key);
            }
            for (int i = 0; i < list.Count() && Lst.Count < k; i++)
            {
                if (list[i] != null)
                {
                    Lst.Add(list[i]);
                }
            }
            return Lst.ToArray();

        }
    }
}
