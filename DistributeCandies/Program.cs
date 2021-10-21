using System;
using System.Linq;

namespace DistributeCandies
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] candyType = { 1, 1, 2, 2, 3, 3 };
    
            Console.WriteLine(DistributeCandies(candyType));
        }

        public static int DistributeCandies(int[] candyType)
        {
            int[] q = candyType.Distinct().ToArray();

            int i = candyType.Length / 2;

            return Math.Min(i, q.Length);
        }


    }
}
