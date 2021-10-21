using System;

namespace MaxCounters
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] A = { 3, 4, 5, 6, 10001, 4, 4 };
            Console.WriteLine(Solution(10000,A));
        }

        private static int[] Solution(int N, int[] A)
        {
            int[] counters = new int[N];
            int counterMaxValue = 0;
            bool wasPrevOpMaxCounter = false;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == N + 1)
                {
                    if (wasPrevOpMaxCounter || counterMaxValue == 0) continue;

                    for (int j = 0; j < counters.Length; j++)
                    {
                        counters[j] = counterMaxValue;
                    }
                    wasPrevOpMaxCounter = true;
                    continue;
                }
                if (++counters[A[i] - 1] > counterMaxValue) counterMaxValue++;
                wasPrevOpMaxCounter = false;
            }
            return counters;
        }



    }
 
    }
