using System;

namespace KClosestPointstoOrigin
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] points = {{3, 3},
                   {5, -1},
                   {-2, 4}};
            int K = 2;
            pClosest(points, K);
           
        }

        private static void pClosest(int[,] points, int k)
        {
            int n = points.GetLength(0);

            int[] distance = new int[n];

            for (int i = 0; i < n; i++)
            {
                int x = points[i, 0],
                    y = points[i, 1];
                distance[i] = (x * x) +
                              (y * y);
            }

            Array.Sort(distance);

            // Find the k-th distance
            int distk = distance[k - 1];

            // Print all distances which are
            // smaller than k-th distance
            for (int i = 0; i < n; i++)
            {
                int x = points[i, 0],
                    y = points[i, 1];
                int dist = (x * x) +
                           (y * y);

                if (dist <= distk)
                    Console.WriteLine("[" + x +
                                      ", " + y + "]");
            }
        }
    }
}
