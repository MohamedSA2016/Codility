using System;
using System.Collections.Generic;

using System.Linq;

namespace Bracket_Combinations
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(BracketCombinations(Convert.ToInt32(Console.ReadLine())));
        }

        public static int BracketCombinations(int num)
        {
            return BracketCombinationList(num).Count();
        }

        public static IEnumerable<string> BracketCombinationList(int num)
        {
            if (num == 0)
                return new[] { "" };
            if (num == 1)
                return new[] { "()" };
            var r1 = BracketCombinationList(num - 1);
            var r2 = new HashSet<string>();
            foreach (var r in r1)
            {
                for (var i = 0; i < r.Length; i++)
                {
                    for (var j = i + 1; j < r.Length + 1; j++)
                    {
                        var t = r.ToList();
                        t.Insert(i, '(');
                        t.Insert(j, ')');
                        r2.Add(new string(t.ToArray()));
                    }
                }
            }
            return r2;
        }
    }
}
