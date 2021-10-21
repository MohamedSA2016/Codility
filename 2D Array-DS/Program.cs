using System;
using System.IO;

namespace _2D_Array_DS
{
    class Program
    {
        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
            int[][] arr = new int[6][];

            for(int i = 0; i<6; i++)
            {
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }
            int result = hourglassSum(arr);

            textWriter.WriteLine(result);
            textWriter.Flush();
            textWriter.Close();
        }

        private static int hourglassSum(int[][] arr)
        {
            int maxHourglassSum = int.MinValue;

            for (int i = 0; i < 4; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    maxHourglassSum = getHourglassSum(arr, i, j) > maxHourglassSum ?
                            getHourglassSum(arr, i, j) :
                            maxHourglassSum;
                }
            }
            return maxHourglassSum;
        }

        private static int getHourglassSum(int[][] arr, int i, int j)
        {
            return arr[i][j] + arr[i][j + 1] + arr[i][j + 2]
                             + arr[i + 1][j + 1]
                 + arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2];
        }
    }
    }

