using System;
using System.Linq;

namespace FlatlandSpaceStations
{
    public class Startup
    {
        private static int MaximumDistance(int cities, int citiesWithStations, int[] indexesOfCitiesWithStations)
        {
            if (cities == citiesWithStations)
            {
                return 0;
            }

            Array.Sort(indexesOfCitiesWithStations);
            int maxDistance = indexesOfCitiesWithStations[0];

            for (int i = 1; i < citiesWithStations; i++)
            {
                int distance = (indexesOfCitiesWithStations[i] - indexesOfCitiesWithStations[i - 1]) / 2;

                if (distance > maxDistance)
                {
                    maxDistance = distance;
                }
            }

            int lastSpaceStationDistance = cities - 1 - indexesOfCitiesWithStations[citiesWithStations - 1];

            if (lastSpaceStationDistance > maxDistance)
            {
                maxDistance = lastSpaceStationDistance;
            }

            return maxDistance;
        }

        private static int MaximumDistance2(int cities, int citiesWithStations, int[] indexesOfCitiesWithStations)
        {
            if (cities == citiesWithStations)
            {
                return 0;
            }

            int[] distances = new int[cities];

            for (int i = 0; i < cities; i++)
            {
                if (indexesOfCitiesWithStations.Contains(i))
                {
                    distances[i] = 0;
                }
                else
                {
                    int minDistance = int.MaxValue;
                    for (int j = 0; j < citiesWithStations; j++)
                    {
                        int currentDistance = Math.Abs(indexesOfCitiesWithStations[j] - i);

                        if (currentDistance < minDistance)
                        {
                            minDistance = currentDistance;
                        }
                    }

                    distances[i] = minDistance;
                }
            }

            return distances.Max();
        }

        public static void Main()
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int cities = input[0];
            int citiesWithStations = input[1];

            int[] indexesOfCitiesWithStations = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int maximumDistance = MaximumDistance(cities, citiesWithStations, indexesOfCitiesWithStations);
            Console.WriteLine(maximumDistance);
        }
    }
}
