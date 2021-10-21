using System;

namespace MaximumUnitsonaTruck
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] boxtype = {
                new int[] {0,2},
                new int[]{ 2, 2 },
                new int[]{ 3, 1 }
            };
            int truckSize = ( 4 );
            Console.WriteLine(Solution(boxtype, truckSize));
        }

        private static int Solution(int[][] boxtype, int truckSize)
        {

            Array.Sort(boxtype, (x, y) => y[1].CompareTo(x[1])); // O(nlogn), sorting based on no of units in each type of box
            int maxUnits = 0, i = 0, minUnitThatCanBeExtracted;
            while (truckSize > 0 && i < boxtype.Length)         // O(Min(n,m)
            {
                minUnitThatCanBeExtracted = Math.Min(boxtype[i][0], truckSize);

                maxUnits += minUnitThatCanBeExtracted * boxtype[i][1];
                truckSize -= minUnitThatCanBeExtracted;
                i++;
            }
            return maxUnits;
        }
    }
}
