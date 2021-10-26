using System;
using System.Collections.Generic;
using System.Linq;

namespace TopKFrequentWords1
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 2;
           
            var words = new string[] { "i", "love", "leetcode", "i", "love", "coding" };

           


            var res = TopKFrequentWords1( words,  k);
            foreach (var item in res)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }

        private static IList<string> TopKFrequentWords1(string[] words, int k)
        {
            Dictionary<string, int> dic = new Dictionary<string, int>();
            foreach (string word in words)
            {
                dic.TryAdd(word, 0);
                dic[word]++;
            }
            Dictionary<int, List<string>> dic2 = new Dictionary<int, List<string>>();
            List<int> list = new List<int>();
            foreach (KeyValuePair<string, int> kvp in dic)
            {
                dic2.TryAdd(kvp.Value, new List<string>());
                dic2[kvp.Value].Add(kvp.Key);
                if (!list.Contains(kvp.Value))
                    list.Add(kvp.Value);
            }
            List<string> retList = new List<string>();
            list = list.OrderByDescending(x => x).ToList();

            int i = 0;
            while (k > retList.Count)
            {
                dic2[list[i]] = dic2[list[i]].OrderBy(x => x).ToList();
                foreach (string str in dic2[list[i]])
                {
                    if (retList.Count == k)
                        break;
                    retList.Add(str);
                }

                i++;

            }



            return retList;
        }
    }
}
