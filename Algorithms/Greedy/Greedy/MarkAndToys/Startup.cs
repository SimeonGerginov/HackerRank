using System;
using System.Linq;

namespace MarkAndToys
{
    public class Startup
    {
        private static int MaximumNumberOfToys(int[] prices, int numberOfToys, int amountToSpend)
        {
            Array.Sort(prices);
            int maximumNumberOfToys = 0;

            for (int i = 0; i < numberOfToys; i++)
            {
                if (amountToSpend == 0)
                {
                    break;
                }

                if (amountToSpend >= prices[i])
                {
                    amountToSpend -= prices[i];
                    maximumNumberOfToys++;
                }
            }

            return maximumNumberOfToys;
        }

        public static void Main()
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int numberOfToys = input[0];
            int amountToSpend = input[1];

            int[] prices = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int maximumNumberOfToys = MaximumNumberOfToys(prices, numberOfToys, amountToSpend);
            Console.WriteLine(maximumNumberOfToys);
        }
    }
}
