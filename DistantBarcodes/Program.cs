using System;
using System.Collections.Generic;
using System.Linq;

namespace DistantBarcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] barcodes = { 1, 1, 1, 2, 2, 2 };
            Console.WriteLine($"[{String.Join(", ", barcodes)}] -> [{String.Join(", ", RearrangeBarcodes(barcodes))}]");

        }

        private static  int[] RearrangeBarcodes(int[] barcodes)
        {
            Dictionary<int, int> count = new Dictionary<int, int>();

            foreach (var barcode in barcodes)
            {
                if (!count.ContainsKey(barcode))
                    count.Add(barcode, 1);

                else
                    count[barcode]++;

            }
            count =
           count.OrderBy(x => -x.Value).ToDictionary(x => x.Key, x => x.Value);


            int index = 0;
            var ans = new int[barcodes.Length];
            foreach (var key in count.Keys)
            {
                int times = count[key];

                while (times > 0)
                {
                    ans[index] = key;
                    index += 2;

                    if (index >= barcodes.Length) index = 1;
                    times--;

                }
            }
            return ans;

        }
    }
}
