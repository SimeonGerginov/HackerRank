using System;
using System.Linq;

namespace JumpingOnTheClouds
{
    public class Startup
    {
        private static int MinimumNumberOfJumps(int numberOfClouds, int[] clouds)
        {
            int counter = -1;

            for (int i = 0; i < numberOfClouds; i++)
            {
                if (i + 2 < numberOfClouds && clouds[i + 2] == 0)
                {
                    i++;
                }

                counter++;
            }

            return counter;
        }

        public static void Main()
        {
            int numberOfClouds = int.Parse(Console.ReadLine());
            int[] clouds = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int minimumNumberOfJumps = MinimumNumberOfJumps(numberOfClouds, clouds);
            Console.WriteLine(minimumNumberOfJumps);
        }
    }
}
