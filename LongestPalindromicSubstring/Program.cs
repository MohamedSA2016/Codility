using System;

namespace LongestPalindromicSubstring
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "babad";
            Console.WriteLine(LongestPalindrome(s));
        }

        private static string LongestPalindrome(string s)
        {
            string result = "";
            int n = s.Length;
            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    // Check whether s[i] to s[j] are palindrome strings, if they are, and the length is greater than the length of result, update it
                    int p = i, q = j;
                    bool isPalindromic = true;
                    while (p < q)
                    {
                        if (s[p++] != s[q--])
                        {
                            isPalindromic = false;
                            break;
                        }
                    }
                    if (isPalindromic)
                    {
                        int len = j - i + 1;
                        if (len > result.Length)
                        {
                            result = s.Substring(i, len);
                        }
                    }

                }
            }
            return result;
        }
    }
}
