using System;

namespace Length_of_the_longest_substring_without_repeating_characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "geeksforgeeks";
            Console.WriteLine("the input string is " + str);
            int len = LongestUniqueSubStr(str);
            Console.WriteLine("The length of the longest " +
                      "non-repeating character " +
                      "substring is " + str);
        }

        public static int LongestUniqueSubStr(string str)
        {
            int n = str.Length;

            // Result
            int res = 0;

            for (int i = 0; i < n; i++)
                for (int j = i; j < n; j++)
                    if (areDistinct(str, i, j))
                        res = Math.Max(res, j - i + 1);

            return res;
        }

        public static bool areDistinct(string str, int i, int j)
        {
            // Note : Default values in visited are false
            bool[] visited = new bool[26];

            for (int k = i; k <= j; k++)
            {
                if (visited[str[k] - 'a'] == true)
                    return false;

                visited[str[k] - 'a'] = true;
            }
            return true;
        }
    }
}
