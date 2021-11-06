using System;

namespace TrappingRainWater
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] height = { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };
            Console.WriteLine(Trap(height));
        }

        private static int Trap(int[] height)
        {
            var res = 0;
            var max = 0;
            var maxindex = 0;
            for(int i =0; i<height.Length;i++)
            {
                if(height[i]>max)
                {
                    max = height[i];
                    maxindex = i;

                }
            }
            var leftmax = 0;
            for(int i = 0; i<maxindex;i++)
            {
                leftmax = Math.Max(leftmax, height[i]);
                res += leftmax - height[i];


            }
            var rightmax = 0;
            for(int i =height.Length-1;i>=maxindex;i--)
            {
                rightmax = Math.Max(rightmax, height[i]);
                res += rightmax - height[i];
            }
            return res;
        }
    }
}
