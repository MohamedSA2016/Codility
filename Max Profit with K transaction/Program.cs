using System;

namespace Max_Profit_with_K_transaction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] price = { 5, 11, 3, 50, 60, 90 };
            int k = (2);
            Console.WriteLine(MaxProfitWithKTransaction(price,k));
        }

        private static int MaxProfitWithKTransaction(int[] price, int k)
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
