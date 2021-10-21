using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { -6, -91, 1011, -100, 84, -22, 0, 1, 473 };
            Console.WriteLine(Solution(A));
        }

        public static int Solution(int[] A)
        {
            const int A_MAX = 100000;

            int[] B = new int[A_MAX];

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] <= 0 || A[i] > A_MAX) continue;
                B[A[i] - 1]++;
            }

            for (int i = 0; i < B.Length; i++)
            {
                if (B[i] == 0) return i + 1;
            }
            return A_MAX + 1;
           }
    }
}
