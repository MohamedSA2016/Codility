using System;

namespace SetMismatch
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] nums = { 1, 2, 2, 4 };

            Console.WriteLine(FindErrorNums(nums));
        }

        private static int[] FindErrorNums(int[] nums)
        {

            int reapated = -1;

            int missing = -1;

            int[] array = new int[nums.Length + 1];
            foreach(var num in nums)
            {
                array[num]++;


            }
            for(int i = 1; i<array.Length;i++)
            {
                if(reapated>-1 && missing >-1)
                {
                    break;
                }
                if(array[i]==0)
                {
                    missing = i;
                }
                else if(array[i]>1)
                {
                    reapated = i;
                }
            }
            return new int[] {reapated,missing};
        }
        
    }
}
