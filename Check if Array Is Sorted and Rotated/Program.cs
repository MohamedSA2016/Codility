using System;

namespace Check_if_Array_Is_Sorted_and_Rotated
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] nums = { 2, 1 };
            Console.WriteLine("\nSorted array: [{0}]", string.Join(", ", nums));
            Console.WriteLine("Check if Array Is Sorted and Rotated " + Check(nums));
        }

        private static bool Check(int[] nums)
        {
            int count = 0;
            for(int i =0; i<nums.Length;i++)
            {
                if(nums[i] > nums[(i+1)% nums.Length])
                {
                    count++;
                }
                if(count > 1)
                {
                    return false;
                }
               
            }
            return true;
        }
    }
}
