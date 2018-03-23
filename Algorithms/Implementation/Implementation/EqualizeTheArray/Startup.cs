using System;
using System.Collections.Generic;
using System.Linq;

namespace EqualizeTheArray
{
    public class Startup
    {
        private static int MinimumDeletedValues(int numberOfElements, int[] numbers)
        {
            List<int> listOfNumbers = new List<int>(numbers);

            int mostCommonElement = listOfNumbers
                         .GroupBy(n => n)
                         .OrderByDescending(gr => gr.Count())
                         .Take(1)
                         .Select(gr => gr.Key)
                         .ToList()[0];

            listOfNumbers.RemoveAll(n => n != mostCommonElement);

            return numbers.Length - listOfNumbers.Count();
        }

        public static void Main()
        {
            int numberOfElements = int.Parse(Console.ReadLine());
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int minimumDeletedValues = MinimumDeletedValues(numberOfElements, numbers);
            Console.WriteLine(minimumDeletedValues);
        }
    }
}
