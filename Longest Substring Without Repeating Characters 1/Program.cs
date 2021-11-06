using System;
using System.Collections.Generic;
namespace Longest_Substring_Without_Repeating_Characters_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "abcabcbb";
            Console.WriteLine(LengthOfLongestSubstring(s));
        }

        private static int LengthOfLongestSubstring(string s)
        {
            int length = 0;
            for (int start = 0; start < s.Length; start++)
            {
                int i = start;
                var dic = new Dictionary<char, int>();
                while(i<s.Length && !dic.ContainsKey(s[i]))
                {
                    dic.Add(s[i++], 1);

                }
                if(i-start>length)
                {
                    length = i - start;
                }
            }
            return length;
        }
    }
}
