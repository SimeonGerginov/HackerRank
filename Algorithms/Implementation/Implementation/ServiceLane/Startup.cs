using System;
using System.Linq;

namespace ServiceLane
{
    public class Startup
    {
        private static int MaximumSizeVehicle(int[] widths, int numberOfWidthMeasurments, int startIndexOfSegment, int endIndexOfSegment)
        {
            int maximumSizeVehicle = int.MaxValue;

            for (int i = startIndexOfSegment; i <= endIndexOfSegment; i++)
            {
                if (widths[i] < maximumSizeVehicle)
                {
                    maximumSizeVehicle = widths[i];
                }
            }

            return maximumSizeVehicle;
        }

        public static void Main()
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int numberOfWidthMeasurments = input[0];
            int testCases = input[1];

            int[] widths = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for (int i = 0; i < testCases; i++)
            {
                int[] indexes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                int startIndexOfSegment = indexes[0];
                int endIndexOfSegment = indexes[1];

                int result = MaximumSizeVehicle(widths, numberOfWidthMeasurments, startIndexOfSegment, endIndexOfSegment);
                Console.WriteLine(result);
            }
        }
    }
}
