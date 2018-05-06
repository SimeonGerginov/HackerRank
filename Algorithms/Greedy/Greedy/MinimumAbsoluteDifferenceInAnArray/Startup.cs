using System;
using System.Linq;

namespace MinimumAbsoluteDifferenceInAnArray
{
    public class Startup
    {
        private static int MinDifference(int[] integers, int numberOfIntegers)
        {
            Array.Sort(integers);
            int minDifference = int.MaxValue;

            for (int i = 1; i < numberOfIntegers; i++)
            {
                minDifference = Math.Min(minDifference, Math.Abs(integers[i] - integers[i - 1]));
            }

            return minDifference;
        }

        public static void Main()
        {
            int numberOfIntegers = int.Parse(Console.ReadLine());
            int[] integers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int minDifference = MinDifference(integers, numberOfIntegers);
            Console.WriteLine(minDifference);
        }
    }
}
