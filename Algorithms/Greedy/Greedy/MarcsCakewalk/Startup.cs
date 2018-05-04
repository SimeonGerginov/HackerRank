using System;
using System.Linq;

namespace MarcsCakewalk
{
    public class Startup
    {
        private static long MinimumNumberOfMiles(int[] calories, int numberOfCupcakes)
        {
            Array.Sort(calories);

            long minCalories = calories[numberOfCupcakes - 1];
            double number = 2;
            double power = 1;

            for (int i = numberOfCupcakes - 2; i >= 0; i--)
            {
                minCalories = minCalories + (long)Math.Pow(number, power) * calories[i];
                power++;
            }

            return minCalories;
        }

        public static void Main()
        {
            int numberOfCupcakes = int.Parse(Console.ReadLine());
            int[] calories = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            long minimumNumberOfMiles = MinimumNumberOfMiles(calories, numberOfCupcakes);
            Console.WriteLine(minimumNumberOfMiles);
        }
    }
}
