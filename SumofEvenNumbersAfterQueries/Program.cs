using System;

namespace SumofEvenNumbersAfterQueries
{
    class Program
    {
        static void BalanceArray(int[] A, int[,] Q)
        {
            int[] ANS = new int[A.Length];

            int i, sum = 0;

            for (i = 0; i < A.Length; i++)

                // If current element is even
                if (A[i] % 2 == 0)
                    sum = sum + A[i];

            for (i = 0; i < Q.GetLength(0); i++)
            {

                int index = Q[i, 0];
                int value = Q[i, 1];

                // If element is even then
                // remove it from sum
                if (A[index] % 2 == 0)
                    sum = sum - A[index];

                A[index] = A[index] + value;

                // If the value becomes even after updating
                if (A[index] % 2 == 0)
                    sum = sum + A[index];

                // Store sum for each query
                ANS[i] = sum;
            }

            // Print the result for every query
            for (i = 0; i < ANS.Length; i++)
                Console.Write(ANS[i] + " ");
        }

        // Driver code
        public static void Main()
        {
            int[] A = { 1, 2, 3, 4 };
            int[,] Q = { { 0, 1 },
                                { 1, -3 },
                                { 0, -4 },
                                { 3, 2 } };
            BalanceArray(A, Q);
        }
    }
}
