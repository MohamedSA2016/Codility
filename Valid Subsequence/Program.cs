using System;

namespace Valid_Subsequence
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
            var posS = 0;
            var posT = 0;

            while (posS < s.Length && posT < t.Length)
            {
                if (t[posT++] == s[posS])
                {
                    posS++;
                }
            }

            return posS == s.Length;

        }
    }
}
