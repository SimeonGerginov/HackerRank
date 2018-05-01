using System;
using System.Collections.Generic;

namespace ClosestNumbers
{
    public class Startup
    {
        private static IList<int> ClosestNumbers(int[] arrayOfNumbers, int numberOfElements)
        {
            IList<int> result = new List<int>();
            int minimumDifference = int.MaxValue;
            Array.Sort(arrayOfNumbers);

            for (int i = 1; i < numberOfElements; i++)
            {
                int difference = Math.Abs(arrayOfNumbers[i] - arrayOfNumbers[i - 1]);

                if (difference < minimumDifference)
                {
                    minimumDifference = difference;
                }
            }

            for (int i = 1; i < numberOfElements; i++)
            {
                int difference = Math.Abs(arrayOfNumbers[i] - arrayOfNumbers[i - 1]);

                if (difference == minimumDifference)
                {
                    result.Add(arrayOfNumbers[i - 1]);
                    result.Add(arrayOfNumbers[i]);
                }
            }

            return result;
        }

        public static void Main()
        {
            int numberOfElements = int.Parse(Console.ReadLine());
            int[] arrayOfNumbers = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            IList<int> result = ClosestNumbers(arrayOfNumbers, numberOfElements);
            Console.WriteLine(String.Join(" ", result));
        }
    }
}
