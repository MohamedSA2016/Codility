using System;
using System.Collections.Generic;
using System.Linq;

namespace CombinationSum
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<IList<int>> allSubsets = CombinationSum3(3, 9);

            Console.Write("All possible combinations for sum: \n[\n");
            for (int k = 0; k < allSubsets.Count; k++)
            {
                IList<int> sub = allSubsets[k];
                Console.Write("\t[");
                for (int i = 0; i < sub.Count; i++)
                {
                    Console.Write(sub[i]);
                    if (i < sub.Count - 1)
                    {
                        Console.Write(", ");
                    }
                }

                if (k < allSubsets.Count - 1)
                {
                    Console.Write("],\n");
                }
                else
                {
                    Console.Write("]\n");
                }
            }

            Console.Write("]");
            Console.ReadKey();
        }
     

        public static IList<IList<int>> CombinationSum3(int k, int n)
        {
            IList<IList<int>> lstOflst = new List<IList<int>>();
            Helper(lstOflst, k, n, new List<int>(), 0, 1);
            return lstOflst;

        }

        private static void Helper(IList<IList<int>> lstOflst, int k, int n, List<int> nums, int sum, int nextNum)
        {
            // if count and sum matches the requirement
            if (sum == n && nums.Count == k)
            {
                lstOflst.Add(new List<int>(nums));
                return;
            }

            // check for next number to be added to the list "nums"
            for (int j = nextNum; j < 10; j++)
            {
                // break loop if the sum exceed the required total n
                if (sum + j > n)
                {
                    break;
                }
                else
                {
                    // add current number to the list
                    nums.Add(j);
                    // add the number in sum
                    sum += j;
                    // check for next number to be added to the list
                    Helper(lstOflst, k, n, nums, sum, j + 1);
                    // subtract the number from the sum
                    sum -= j;
                    // remove the number from the list
                    nums.RemoveAt(nums.Count - 1);
                }
            }

        } 
        
    }
}
