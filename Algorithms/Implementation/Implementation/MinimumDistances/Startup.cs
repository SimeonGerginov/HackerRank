using System;
using System.Linq;

namespace MinimumDistances
{
    public class Startup
    {
        private static int MinDistanceBetweenEqualElements(int[] elements, int sizeOfArray)
        {
            int minDistance = int.MaxValue;

            for (int i = 0; i < sizeOfArray; i++)
            {
                for (int j = i + 1; j < sizeOfArray; j++)
                {
                    if (elements[i] == elements[j])
                    {
                        int currentDistance = Math.Abs(i - j);
                        if (minDistance > currentDistance)
                        {
                            minDistance = currentDistance;
                        }
                    }
                }
            }

            if (minDistance == int.MaxValue)
            {
                minDistance = -1;
            }

            return minDistance;
        }

        public static void Main()
        {
            int sizeOfArray = int.Parse(Console.ReadLine());
            int[] elements = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int minDistanceBetweenEqualElements = MinDistanceBetweenEqualElements(elements, sizeOfArray);
            Console.WriteLine(minDistanceBetweenEqualElements);
        }
    }
}
