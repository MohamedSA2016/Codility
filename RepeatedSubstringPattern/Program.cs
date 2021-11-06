using System;

namespace RepeatedSubstringPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "aba";
            Console.WriteLine(RepeatedSubstringPattern(s));
        }

        private static bool RepeatedSubstringPattern(string s)
        {
            int n = s.Length;
            if (n <= 1)
                return false;
            for (int i = n / 2; i > 1; i--)
            {
                if (n % i == 0)
                {
                    if (checkSubString(s, i))
                        return true;
                }
            }
            for (int i = 0; i < n; i++)
            {
                if (s[i] != s[0])
                    return false;
            }
            return true;

        }

        private static bool checkSubString(string s, int index)
        {
            int range = s.Length / index;
            for (int i = 0; i < range; i++)
            {
                char currVal = s[i];
                for (int j = range; j < s.Length; j += range)
                {
                    if (s[i + j] != currVal)
                        return false;
                }
            }
            return true;
        }
    }
}
