using System;

namespace FindPeakElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1,2,3,1};
            Console.WriteLine(FindPeakElement(nums));
        }

        private static int FindPeakElement(int[] nums)
        {
            int low = 0, high = nums.Length - 1;
            while(low<=high)
            {
                var mid = (high - low) / 2 + low;
                var before = (mid == 0 ? long.MinValue : nums[mid - 1]);
                var after = (mid == nums.Length - 1 ? long.MinValue : nums[mid + 1]);
                if (nums[mid] > before && nums[mid] > after)
                    return mid;
                else if (nums[mid] < before && nums[mid] < after)
                    high = mid - 1;
                else if (nums[mid] < before && nums[mid] > after)
                    high = mid - 1;
                else
                    low = mid + 1;
            }
            return int.MinValue;
        }
    }
}
