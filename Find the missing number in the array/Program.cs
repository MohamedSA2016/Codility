using System;

namespace Find_the_missing_number_in_the_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 3, 0, 1 };
            Console.WriteLine(MissingNumber(nums));
        }

        private static int MissingNumber(int[] nums)
        {
            int overAllSum = nums.Length, sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                overAllSum = overAllSum + i;
                sum = sum + nums[i];
            }
            return overAllSum - sum;
        }
    }
}
