using System;
using System.Linq;

namespace ManasaAndStones
{
    public class Startup
    {
        private static int[] PossibleValuesOfTheLastStone(int numberOfStones, int firstDifference, int secondDifference)
        {
            int floor = Math.Min(firstDifference, secondDifference) * (numberOfStones - 1);
            int difference = Math.Abs(firstDifference - secondDifference);

            return Enumerable.Range(0, numberOfStones)
                        .Select(i => floor + difference * i)
                        .Distinct()
                        .ToArray();
        }

        public static void Main()
        {
            int testCases = int.Parse(Console.ReadLine());
            for (int i = 0; i < testCases; i++)
            {
                int numberOfStones = int.Parse(Console.ReadLine());
                int firstDifference = int.Parse(Console.ReadLine());
                int secondDifference = int.Parse(Console.ReadLine());

                int[] possibleValuesOfTheLastStone = PossibleValuesOfTheLastStone(numberOfStones, firstDifference, secondDifference);
                Console.WriteLine(string.Join(" ", possibleValuesOfTheLastStone));
            }
        }
    }
}
