using System;
using System.Collections.Generic;
using System.Linq;

namespace Distinct
{
    class Program
    {

       
        static void Main(string[] args)
        {
            int[] A = { 1, 2, 3, 3 };
            Console.WriteLine(Solution(A));
        }

        private static int Solution(int[] A)
        {
            if (A.Length == 0)
            {
                return 0;
            }

            Array.Sort(A);

            int distinctCount = 1;
            for (int i = 1; i < A.Length; i++)
            {
                if (A[i] != A[i - 1])
                {
                    distinctCount++;
                }
            }

            return distinctCount;
        }
    }

  
}
