using System;

namespace Remove_Palindromic_Subsequences
{
    class Program
    {
        static void Main(string[] args)
        {


            string s = ("ababa");
            Console.WriteLine(RemovePalindromeSub(s));
        }

        private static int RemovePalindromeSub(string s)
        {
            var n = s.Length;

            if (n == 0)
                return 0;

            for (int i = 0, j = n - 1; i < j; i++, j--)
            {
                if (s[i] != s[j])
                    return 2;
            }
            return 1;

            
        }
    }
}
