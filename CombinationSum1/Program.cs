using System;
using System.Collections.Generic;
using System.Linq;

namespace CombinationSum1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] candidates = { 2, 3, 6, 7 };
            int target = 7;

            Console.WriteLine(CombinationSum(candidates, target));
        }

        private static IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            IList<IList<int>> results = new List<IList<int>>();
            List<int> crnt = new List<int>();

            Array.Sort(candidates);

            Combine(candidates, target, results, crnt, 0);

            return results;
        }

        private static void Combine(int[] candidates, int target, IList<IList<int>> results, List<int> crnt, int start)
        {
            if (target == 0)
            {
                results.Add(crnt.ToList());
                return;
            }

            int j;

            for (int i = start; i < candidates.Length && candidates[i] <= target; i++)
            {
                j = 1;
                while (j <= (target / candidates[i]))
                {
                    crnt.Add(candidates[i]);
                    Combine(candidates, target - j * candidates[i], results, crnt, i + 1);
                    j++;
                }

                while (j > 1) { crnt.RemoveAt(crnt.Count - 1); j--; }
            }

        }
    }
}

