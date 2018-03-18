using System;
using System.Linq;

namespace TheHurdleRace
{
    public class Startup
    {
        private static int NumberOfBeveragesToDrink(int numberOfHurdles, int maximumHeight, int[] hurdles)
        {
            int maxHeightOfHurdles = hurdles.Max();

            if (maxHeightOfHurdles > maximumHeight)
            {
                return maxHeightOfHurdles - maximumHeight;
            }
            else
            {
                return 0;
            }
        }

        public static void Main()
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int numberOfHurdles = input[0];
            int maximumHeight = input[1];

            int[] hurdles = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int numberOfBeveragesToDrink = NumberOfBeveragesToDrink(numberOfHurdles, maximumHeight, hurdles);
            Console.WriteLine(numberOfBeveragesToDrink);
        }
    }
}
