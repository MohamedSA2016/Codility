using System;
using System.Collections.Generic;
using System.Linq;

namespace GenerateParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 3;

            Console.WriteLine(GenerateParenthesis(n));
        }

      

         private static IList<string> GenerateParenthesis(int n)
        {
            List<ParenthesesGenerating> list = new List<ParenthesesGenerating>();
            if (n == 0)
            {
                return new List<string>();
            }
            list.Add(new ParenthesesGenerating(n - 1, n, "("));

            for (var i = 1; i < n * 2; i++)
            {
                List<ParenthesesGenerating> temp = new List<ParenthesesGenerating>();

                foreach (var l in list)
                {
                    if (l.Open != 0)
                    {
                        temp.Add(new ParenthesesGenerating(l.Open - 1, l.Close, l.Str + "("));
                    }
#pragma warning disable CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
                    if (l.Close != null && l.Close > l.Open)
#pragma warning restore CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
                    {
                        temp.Add(new ParenthesesGenerating(l.Open, l.Close - 1, l.Str + ")"));
                    }

                }
                list = temp.ToList();
            }

            return list.Select(x => x.Str).ToList();
        }
    }
    }

