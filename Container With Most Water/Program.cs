using System;

namespace Container_With_Most_Water
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] container = new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 };

            int max = MaxArea(container);
        }

        private static int MaxArea(int[] height)
        {
            int maxArea = 0;
            for (int i = 0; i < height.Length; i++)
            {
                for (int j = 0; j < height.Length; j++)
                    maxArea = Math.Max(maxArea, Math.Abs(i - j) * Math.Min(height[i], height[j]));
            }

            return maxArea;

        }
    }
}
