using System;
using System.Collections.Generic;

namespace Reorder_Data_in_Log_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] logs = { "dig1 8 1 5 1", "let1 art can", "dig2 3 6", "let2 own kit dig", "let3 art zero" };
            Console.WriteLine(ReorderLogFiles(logs));
        }

        private static string[] ReorderLogFiles(string[] logs)
        {
            SortedDictionary<string, List<string>> sDic = new SortedDictionary<string, List<string>>();
            string[] res = new string[logs.Length];
            int index = logs.Length - 1;
            for (int i = logs.Length - 1; i >= 0; i--)
            {
                string tStr = logs[i];
                if (char.IsDigit(tStr.TrimEnd()[tStr.Length - 1]))
                {
                    res[index--] = tStr;
                }
                else
                {
                    string strArr = logs[i].Substring(logs[i].IndexOf(' '));
                    if (!sDic.ContainsKey(strArr))
                        sDic.Add(strArr, new List<string>() { tStr });
                    else
                        sDic[strArr].Add(tStr);
                }

            }
            index = 0;
            foreach (string key in sDic.Keys)
            {
                if (sDic[key].Count > 1) sDic[key].Sort();
                for (int i = 0; i < sDic[key].Count; i++)
                    res[index++] = sDic[key][i];
            }
            return res;
        }
    }
}
