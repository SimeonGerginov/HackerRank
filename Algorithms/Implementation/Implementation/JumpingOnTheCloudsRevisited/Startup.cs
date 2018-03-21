using System;
using System.Linq;

namespace JumpingOnTheCloudsRevisited
{
    public class Startup
    {
        private static int FindEnergyValue(int numberOfClouds, int jumpDistance, int[] valuesOfClouds)
        {
            int energy = 100;
            int index = 0;

            do
            {
                index = (index + jumpDistance) % numberOfClouds;
                if (valuesOfClouds[index] == 1) 
                {
                    energy = energy - 1 - 2;
                } 
                else
                {
                    energy = energy - 1;
                }
            } while (index != 0);

            return energy;
        }

        public static void Main()
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int numberOfClouds = input[0];
            int jumpDistance = input[1];

            int[] valuesOfClouds = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int energyValue = FindEnergyValue(numberOfClouds, jumpDistance, valuesOfClouds);
            Console.WriteLine(energyValue);
        }
    }
}
