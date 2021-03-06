using System;

namespace Minimum_Difficulty_of_a_Job_Schedule
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] jobDifficulty = { 6, 5, 4, 3, 2, 1 };
            int d = 2;
            Console.WriteLine(MinDifficulty(jobDifficulty,d));
        }

        private static int MinDifficulty(int[] jobDifficulty, int d)
        {
            int len = jobDifficulty.Length;
            if (len < d)
                return -1;

            int[][] data = new int[len][];
            int[][] max = new int[len][];
            for( int i = 0; i <len;i++)

            {
                data[i] = new int[d];
                max[i] = new int[len];
                max[i][i] = jobDifficulty[i];
                for(int j = i +1; j<len;j++)
                {
                    max[i][j] = Math.Max(max[i][j - 1], jobDifficulty[j]);
                }
                data[i][0] = max[i][len - 1];

            }
            for(int i =1; i<d;i++)
            {
                for(int j = len-1; j>=0;j--)
                {
                    int t = int.MaxValue;
                    for(int k = j; k<len-i;k++)
                    {
                        t = Math.Min(t, max[j][k] + data[k + 1][i - 1]);
                    }
                    data[j][i] = t;

                }
            }
            return data[0][d - 1];

        }
    }
}
