using System;
using System.Linq;

namespace SaveThePrisoner_
{
    public class Startup
    {
        private static int FindIdOfPoisonedPrisoner(int numberOfPrisoners, int numberOfSweets, int prisonerId)
        {
            int poisonedPrisonerId = prisonerId + numberOfSweets - 1;
            if (poisonedPrisonerId > numberOfPrisoners)
            {
                if (poisonedPrisonerId % numberOfPrisoners == 0)
                {
                    return numberOfPrisoners;
                }

                return poisonedPrisonerId % numberOfPrisoners;
            }
            else
            {
                return poisonedPrisonerId;
            }
        }

        public static void Main()
        {
            int testCases = int.Parse(Console.ReadLine());
            for (int i = 0; i < testCases; i++)
            {
                int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                int numberOfPrisoners = input[0];
                int numberOfSweets = input[1];
                int prisonerId = input[2];

                int idOfPoisonedPrisoner = FindIdOfPoisonedPrisoner(numberOfPrisoners, numberOfSweets, prisonerId);
                Console.WriteLine(idOfPoisonedPrisoner);
            }
        }
    }
}
