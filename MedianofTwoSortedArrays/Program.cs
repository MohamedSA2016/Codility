using System;

namespace MedianofTwoSortedArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num1 = { 1,3};
            int[] num2 = { 2 };
            Console.WriteLine(FindMedianSortedArrays(num1,num2));
        }

        private static double FindMedianSortedArrays(int[] num1, int[] num2)
        {
            //Perform Binary search on the smaller array for the min time, swap if necessary
            if (num2.Length < num1.Length)
            {

                int[] temp = num1;
                num1 = num2;
                num2 = temp;
            }

            int low = 0;
            int high = num1.Length;

            int n1 = num1.Length;
            int n2 = num2.Length;

            while (low <= high)
            {

                int part1 = (low + high) / 2;
                int part2 = (n1 + n2) / 2 - part1;

                var left1 = part1 == 0 ? int.MinValue : num1[part1 - 1];
                var right1 = part1 == n1 ? int.MaxValue : num1[part1];

                var left2 = part2 == 0 ? int.MinValue : num2[part2 - 1];
                var right2 = part2 == n2 ? int.MaxValue : num2[part2];

                if (left1 <= right2 && left2 <= right1)
                {
                    if ((n1 + n2) % 2 == 0)
                        return (Math.Min(right1, right2) + Math.Max(left1, left2)) / 2.0;
                    else
                        return Math.Min(right1, right2);
                }
                if (left1 > right2)
                    high = part1 - 1;

                else if (left2 > right1)
                    low = part1 + 1;

            }
            return 0;
        }

        //As requested Binary Search will take O(log(min(n1, n2))) time and O(1) space complexity

    }

}


   

