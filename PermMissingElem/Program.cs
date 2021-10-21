using System;

namespace PermMissingElem
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 1, 2, 4 };
            Console.WriteLine(Solution(A));
        }

        public static int Solution(int[] A)
        {
            var sum = 0;
            for (int i = 0; i < A.Length; i++)
                sum += A[i];

            return A.Length % 2 == 0 ? -sum + (A.Length / 2 + 1) * (A.Length + 1)
             : -sum + (A.Length / 2 + 1) * (A.Length + 2);




        }
    }
}
