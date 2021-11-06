using System;
using System.Collections.Generic;
using System.Linq;
namespace Permutations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3 };
        Console.WriteLine(Permute(nums));
        }

        private static IList<IList<int>> Permute(int[] nums)
        {
            IList<IList<int>> permutations = new List<IList<int>>();
            if (nums.Count() > 0)
            {
                permutations.Add(new List<int> { nums[0] });
            }
            for (var n = 1; n < nums.Count(); n++)
            {
                permutations = AddNewElement(nums[n], permutations);
            }

            return permutations;
        }

        private static IList<IList<int>> AddNewElement(int n, IList<IList<int>> permutations)
        {
            List<IList<int>> newPerm = new List<IList<int>>();

            foreach (var p in permutations)
            {
                for (var index = 0; index <= permutations[0].Count(); index++)
                {
                    var tempP = p.ToList();
                    tempP.Insert(index, n);

                    newPerm.Add(tempP);

                }
            }

            return newPerm;
        }

        
    }
}
