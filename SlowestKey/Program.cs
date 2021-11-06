using System;

namespace SlowestKey
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] keyTimes =
            {
                new int[] {0,2},
                new int[]{1,5},
                new int[]{0,9},
                new int[]{2,15}
            };
            Console.WriteLine(Slowest(keyTimes));
        }

        private static char Slowest(int[][] keyTimes)
        {
            int maxDiff = keyTimes[0][1];
            char key = (char)(keyTimes[0][0] + 'a');
            int preTime = keyTimes[0][1];

            for (int i = 1; i < keyTimes.Length; i++)
            {
                int diff = keyTimes[i][1] - preTime;
                if (diff > maxDiff)
                {
                    maxDiff = diff;
                    key = (char)(keyTimes[i][0] + 'a');
                }

                preTime = keyTimes[i][1];
            }

            return key;
        }
    }
}
