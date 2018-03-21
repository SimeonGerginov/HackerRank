using System;
using System.Linq;

namespace SherlockAndSquares
{
    public class Startup
    {
        private static int CountSquares(int startRange, int endRange)
        {
            return (int)Math.Sqrt(endRange) - (int)Math.Sqrt(startRange - 1);
        }

        public static void Main()
        {
            int testCases = int.Parse(Console.ReadLine());
            for (int i = 0; i < testCases; i++)
            {
                int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                int startRange = input[0];
                int endRange = input[1];

                int numberOfSquaresInRange = CountSquares(startRange, endRange);
                Console.WriteLine(numberOfSquaresInRange);
            }
        }
    }
}
