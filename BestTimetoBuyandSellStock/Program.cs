using System;

namespace BestTimetoBuyandSellStock
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] prices = { 7, 1, 5, 3, 6, 4 };
            Console.WriteLine("The maximum possible profit is"+MaxProfit(prices));
        }

        private static int MaxProfit(int[] prices)
        {
            int profit = 0;
            int maxprofit = 0;
            if(prices ==null || prices.Length<=0)
            {
                return profit;
            }
            int bp = prices[0];
            int sp = -1;
            for(int i = 1; i <prices.Length;i++)
            {
                if(prices[i]<=bp)
                {
                    bp = prices[i];
                    sp = 0;

                }
                else if (prices[i]>=sp)
                {
                    sp = prices[i];
                    profit = sp - bp;
                    maxprofit = Math.Max(profit, maxprofit);
                }
            }
            return maxprofit;
        }
    }
}
