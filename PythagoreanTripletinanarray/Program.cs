using System;

namespace PythagoreanTripletinanarray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ar = { 3, 1, 4, 6, 5 };
            int ar_size = ar.Length;
            if(IsTriplet(ar,ar_size)==true)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }

        private static bool IsTriplet(int[] ar, int ar_size)
        {
            for (int i = 0; i < ar_size; i++)
            {
                for (int j = i + 1; j < ar_size; j++)
                {
                    for (int k = j + 1; k < ar_size; k++)
                    {

                        // Calculate square of array elements
                        int x = ar[i] * ar[i], y = ar[j] * ar[j], z = ar[k] * ar[k];

                        if (x == y + z || y == x + z || z == x + y)
                            return true;
                    }
                }
            }

            // If we reach here,
            // no triplet found
            return false;
        }
    }
}
