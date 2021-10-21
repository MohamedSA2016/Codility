using System;
using System.Collections.Generic;

namespace LongestSubstringWithoutRepeatingCharacters
{
    class Program
    {
        static void Main(string[] args)
        {

            string s = "abcabcbb";
            Console.WriteLine("The input string is " + s);

            int len = LengthOfLongestSubstring(s);
            Console.WriteLine("The length of the longest " +
                              "non-repeating character " +
                              "substring is " + len);
        }

        private static int LengthOfLongestSubstring(string s)
        {

            int length = 0;
            for(int start =0; start<s.Length; start++)
            {
                int i = start;
                var dictionary = new Dictionary<char, int>();

                while (i < s.Length && !dictionary.ContainsKey(s[i]))
                {
                    dictionary.Add(s[i++], 1);
                }
                if (i - start > length)
                {
                    length = i - start;
                }
            }
            return length;
        }
           
        }
    }


