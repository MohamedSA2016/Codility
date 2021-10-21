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
            int maxIndex = keyTimes[0][0];
            int max = keyTimes[0][1];
            int prev = keyTimes[0][1];
            for(int i =1; i<keyTimes.Length;i++)
            {
                int curr = keyTimes[i][1] - prev;
                if(curr > max)
                {
                    maxIndex = keyTimes[i][0];
                    max = curr;

                }
                prev = keyTimes[i][1];

            }
            string table = "abcdefghijklmnopqrstuvwxyz";

            return table(maxIndex);
        }
    }
}
