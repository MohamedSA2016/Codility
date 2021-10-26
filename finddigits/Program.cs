using System;
using System.Collections;
using System.Collections.Generic;

namespace finddigits
{
    class Program
    {
        static void Main(string[] args)
        {

            string digits = ("23");

            Console.WriteLine(LetterCombinations(digits));
        }

        public static IList<string> LetterCombinations(string digits)
        {
           
            string [] map = new string[] { "ranjan", "aaranja", "rnjaan", "ranjan", "rnjaan", "akfekda"};

            IList<string> result = new List<string>();

            result = Dfs(result, map, digits);

            return result;
        }

        private static IList<string> Dfs(IList<string> result, string[] map, string digits)
        {
            if (digits.Length == 0)
                return result;

            IList<string> aux = new List<string>();

            foreach (char c in map[digits[0] - '1'])
            {
                if(result.Count ==0)
                {
                    aux.Add(c.ToString());

                }
                else
                {
                    foreach (string r in result)
                        aux.Add(r + c);

                }
             

            }

            result = Dfs(aux, map, digits.Remove(0, 1));

            return result;
        }
    }
}
