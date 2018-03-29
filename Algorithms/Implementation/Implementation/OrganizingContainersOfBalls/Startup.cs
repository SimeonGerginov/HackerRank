using System;
using System.Linq;

namespace OrganizingContainersOfBalls
{
    public class Startup
    {
        private static string OrganizeContainers(int numberOfBallTypes)
        {
            int[] capacityOfBoxes = new int[numberOfBallTypes];
            int[] totalQuantityOfEachBallType = new int[numberOfBallTypes];

            for (int i = 0; i < numberOfBallTypes; i++)
            {
                int[] rowOfBowls = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int j = 0; j < numberOfBallTypes; j++)
                {
                    int ball = rowOfBowls[j];
                    capacityOfBoxes[i] += ball;
                    totalQuantityOfEachBallType[j] += ball;
                }
            }

            Array.Sort(capacityOfBoxes);
            Array.Sort(totalQuantityOfEachBallType);

            if (Enumerable.SequenceEqual(capacityOfBoxes, totalQuantityOfEachBallType))
            {
                return "Possible";
            }
            else
            {
                return "Impossible";
            }
        }

        public static void Main()
        {
            int numberOfQueries = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfQueries; i++)
            {
                int numberOfBallTypes = int.Parse(Console.ReadLine());
                string organizeContainers = OrganizeContainers(numberOfBallTypes);

                Console.WriteLine(organizeContainers);
            }
        }
    }
}
