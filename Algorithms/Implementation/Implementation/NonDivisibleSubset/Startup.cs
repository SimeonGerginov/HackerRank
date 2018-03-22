using System;
using System.Linq;

namespace NonDivisibleSubset
{
    public class Startup
    {
        private static int FindSizeOfSubset(int countOfNumbers, int divisor, int[] numbers)
        {
            int[] remainders = new int[divisor];
            int counter = 0;

            for (int i = 0; i < countOfNumbers; i++)
            {
                int index = numbers[i] % divisor;
                remainders[index]++;
            }

            for (int i = 1; i <= divisor / 2; i++)
            {
                if (i != divisor - i)
                {
                    counter += Math.Max(remainders[i], remainders[divisor - i]);
                }
                else
                {
                    counter += 1;
                }
            }

            if (remainders[0] > 0)
            {
                counter++;
            }

            return counter;
        }

        public static void Main()
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int countOfNumbers = input[0];
            int divisor = input[1];

            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int sizeOfLargestSubset = FindSizeOfSubset(countOfNumbers, divisor, numbers);
            Console.WriteLine(sizeOfLargestSubset);
        }
    }
}
