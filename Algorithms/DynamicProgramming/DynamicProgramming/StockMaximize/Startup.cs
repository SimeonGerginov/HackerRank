using System;
using System.Linq;

namespace StockMaximize
{
    public class Startup
    {
        public static void Main()
        {
            int numberOfTestCases = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfTestCases; i++)
            {
                int numberOfPredictedPrices = int.Parse(Console.ReadLine());
                int[] prices = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                long maximumProfit = MaxProfit(prices, numberOfPredictedPrices);
                Console.WriteLine(maximumProfit);
            }
        }

        private static long MaxProfit(int[] prices, int numberOfPredictedPrices)
        {
            long maxProfit = 0;
            int currentMax = 0;

            for (int i = numberOfPredictedPrices - 1; i >= 0; i--)
            {
                if (prices[i] >= currentMax)
                {
                    currentMax = prices[i];
                }

                maxProfit += currentMax - prices[i];
            }

            return maxProfit;
        }
    }
}
