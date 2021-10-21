using System;

namespace Increasing_Triplet_Subsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1,2,3,4,5 };
            Console.WriteLine(Check(nums));
        }

        private static bool Check(int[] nums)
        {
            if (nums == null || nums.Length <= 2)
            {
                return false;
            }
            int n = nums.Length;

            int min = Int32.MaxValue;
            int max = Int32.MaxValue;

            for (int i = 0; i < n; i++)
            {
                if (nums[i] > max)
                {
                    return true;
                }
                if (min > nums[i])
                {
                    min = nums[i];
                }
                else if (nums[i] > min && nums[i] < max)
                {
                    max = nums[i];
                }
            }
            return false;
        }
    }
}
