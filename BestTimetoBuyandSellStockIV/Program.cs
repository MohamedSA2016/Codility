using System;

namespace BestTimetoBuyandSellStockIV
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 2;
            int[] price = { 2,4,1};
            Console.WriteLine(MaxProfitIV(k,price));
        }

        private static int MaxProfitIV(int k, int[] price)
        {
            int res = 0;

            if (k > 0)
            {

                int[] kBuy = new int[k];
                Array.Fill(kBuy, int.MinValue);
                int[] kBuykSell = new int[k];

                for (int i = 0; i < price.Length; i++)
                {
                    kBuy[0] = Math.Max(kBuy[0], -price[i]);
                    kBuykSell[0] = Math.Max(kBuykSell[0], price[i] + kBuy[0]);

                    if (k > 1)
                    {
                        for (int j = 1; j < k; j++)
                        {
                            kBuy[j] = Math.Max(kBuy[j], kBuykSell[j - 1] - price[i]);
                            kBuykSell[j] = Math.Max(kBuykSell[j], price[i] + kBuy[j]);
                        }
                    }

                }

                foreach (int item in kBuykSell)
                {
                    if (item > res)
                    {
                        res = item;
                    }
                }
            }

            return res;
        }

    }
        }
    

