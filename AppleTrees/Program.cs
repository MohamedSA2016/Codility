using System;

namespace AppleTrees
{
    class Program
    {
        static void Main(string[] args)
        {
            int minApples =  1 ;
            Console.WriteLine(squarePlotToBuy(minApples));
        }

        private static int squarePlotToBuy(int minApples)
        {
            if (minApples <= 0) throw new ArgumentException(nameof(minApples));

            var count = 0.0;
            var unit = 0;
            while (count < minApples)
            {
                unit++;

                count = 2 * unit * Math.Pow(unit + 1, 2);
            }

            return unit;
        }
    }
}
