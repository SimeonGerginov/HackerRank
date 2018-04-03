using System;
using System.Linq;

namespace BeautifulTriplets
{
    public class Startup
    {
        private static int NumberOfTripletsInSequence(int[] sequence, int lengthOfSequence, int difference)
        {
            int numberOfTriplets = 0;

            for (int i = 0; i < lengthOfSequence; i++)
            {
                for (int j = i + 1; j < lengthOfSequence; j++)
                {
                    if (sequence[j] - sequence[i] == difference)
                    {
                        for (int k = j + 1; k < lengthOfSequence; k++)
                        {
                            if (sequence[k] - sequence[j] == difference)
                            {
                                numberOfTriplets++;
                            }
                        }
                    }
                }
            }

            return numberOfTriplets;
        }

        public static void Main()
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int lengthOfSequence = input[0];
            int difference = input[1];

            int[] sequence = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int numberOfTripletsInSequence = NumberOfTripletsInSequence(sequence, lengthOfSequence, difference);
            Console.WriteLine(numberOfTripletsInSequence);
        }
    }
}
