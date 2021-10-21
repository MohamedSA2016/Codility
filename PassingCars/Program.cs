using System;

namespace PassingCars
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] A = { 0, 1, 0, 1, 1, 0, 0, 1, 1, 1 };
            Console.WriteLine(Solution(A));

            Console.ReadLine();
        }

        private static int Solution(byte[] A)
        {
            int passingCars = 0;
            int prefixSum = 0;
            int indexOfFirstZero = Array.IndexOf(A, (byte)0);

            if (indexOfFirstZero == -1 || A.Length == 1) return 0;

            int possiblePasses = 0;
            for (int i = indexOfFirstZero; i < A.Length; i++)
            {
                if (A[i] == 1) possiblePasses++;
            }

            if (possiblePasses == 0) return 0;

            for (int i = indexOfFirstZero; i < A.Length; i++)
            {
                if (A[i] == 1)
                {
                    prefixSum++;
                }
                else
                {
                    passingCars += possiblePasses - prefixSum;
                    if (passingCars >= 1000000000) return -1;
                }
            }
            return passingCars;
        }
    }
}
