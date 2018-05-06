using System;
using System.Linq;

namespace PriyankaAndToys
{
    public class Startup
    {
        private static int NumberOfContainers(int[] weights, int numberOfOrders)
        {
            Array.Sort(weights);
            int numberOfContainers = 0;
            int containerRange = 4;
            int minElement = weights[0];
            int maxElement = weights[numberOfOrders - 1];
            int counter = 1;

            while (true)
            {
                if (minElement >= maxElement || counter == numberOfOrders)
                {
                    numberOfContainers++;
                    break;
                }

                if (weights[counter] <= minElement + containerRange)
                {
                    counter++;
                    continue;
                }
                else
                {
                    numberOfContainers++;
                    minElement = weights[counter];
                }
            }

            return numberOfContainers;
        }

        public static void Main()
        {
            int numberOfOrders = int.Parse(Console.ReadLine());
            int[] weights = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int numberOfContainers = NumberOfContainers(weights, numberOfOrders);
            Console.WriteLine(numberOfContainers);
        }
    }
}
