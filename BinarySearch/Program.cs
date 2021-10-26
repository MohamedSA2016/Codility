using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { -1, 0, 3, 5, 9, 12 };
            int target = (9);
            Console.WriteLine(Search(nums,target));
        }

        private static int Search(int[] nums, int target)
        {
            // simple checking
            if (target == nums[0])
                return 0;

            // if the last element is the target, then return its index
            else if (target == nums[^1])
            {
                return nums.Length - 1;
            }

            // the upper index is the highest index at start.
            int upper = nums.Length - 1;

            // the lower index is the lowest index at start.
            int lower = 0;

            // this is the index of the element that we'll be comparing against the target.
            int index = upper / 2;

            // a simple check to prevent repetition.
            while (index != upper && index != lower)
            {
                // if it's our target, then return the index.
                if (nums[index] == target)
                    return index;

                // if bigger than target then:
                else if (nums[index] > target)
                {
                    // let the upper limit be the index
                    upper = index;

                    //and set the index to be the center of the upper and lower limits.
                    index -= (index - lower) / 2;
                }
                // if it's smaller than the target then:
                else if (nums[index] < target)
                {
                    // let the lower limit be the index
                    lower = index;

                    // and set the index to be the center of the upper and lower limits.
                    index += (upper - index) / 2;
                }
            }
            // if nothing is satisfied, that means the number doesn't exist.
            return -1;
        }
    }
}
