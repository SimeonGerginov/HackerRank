using System;
using System.Linq;

namespace HalloweenSale
{
    public class Startup
    {
        private static int MaximumNumberOfGamesBought(int price, int difference, int lowCost, int money)
        {
            int maximumGamesBought = 0;

            while (true)
            {
                if (money - price < 0)
                {
                    break;
                }

                money -= price;

                if (price - lowCost < difference)
                {
                    price = lowCost;
                }
                else
                {
                    price -= difference;
                }

                maximumGamesBought++;
            }

            return maximumGamesBought;
        }

        public static void Main()
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int price = input[0];
            int difference = input[1];
            int lowCost = input[2];
            int money = input[3];

            int maximumNumberOfGamesBought = MaximumNumberOfGamesBought(price, difference, lowCost, money);
            Console.WriteLine(maximumNumberOfGamesBought);
        }
    }
}
