using System;
using System.Collections.Generic;

namespace TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 2,7,11,15};
            int target = 9;
            Console.WriteLine(TwoSum(nums, target));
        }

        private static int[] TwoSum(int[] nums, int target)
        {
            var hash = new Dictionary<int, int>();
            for(var i =0;i<nums.Length;i++)
            {
                if (hash.TryGetValue(target - nums[i], out var value))
                {
                    return new int[] { value, i };

                }
                else if(!hash.ContainsKey(nums[i]))
                {
                    hash.Add(nums[i], i);
                }
            }
            return new int[] { 0, 0 };

        }
    }
}
