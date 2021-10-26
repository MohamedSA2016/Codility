using System;

namespace IsSubsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "abc";
            string t = "ahbgdc";
            Console.WriteLine(IsSubsequence(s,t));
        }

        private static bool IsSubsequence(string s, string t)
        {
            if (s.Length == 0) return true;

            int i = 0, j = 0;

            while (i < s.Length && j < t.Length)
            {
                if (s[i] == t[j])
                    i++;
                j++;
            }

            return i == s.Length;
        }
    }
}
