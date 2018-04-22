using System;
using System.Collections.Generic;
using System.Linq;

namespace Quicksort1Partition
{
    public class Startup
    {
        private static void Partition(int[] arrayOfNumbers, int pivot, int sizeOfArray)
        {
            IList<int> left = new List<int>();
            IList<int> equal = new List<int>();
            IList<int> right = new List<int>();

            for (int i = 0; i < sizeOfArray; i++)
            {
                int element = arrayOfNumbers[i];

                if (element == pivot)
                {
                    equal.Add(element);
                }
                else if (pivot > element)
                {
                    left.Add(element);
                }
                else
                {
                    right.Add(element);
                }
            }

            Console.Write(string.Join(" ", left));
            if (left.Count > 0)
            {
                Console.Write(" ");
            }

            Console.Write(string.Join(" ", equal));
            Console.Write(" ");

            Console.Write(string.Join(" ", right));
            Console.WriteLine();
        }

        public static void Main()
        {
            int sizeOfArray = int.Parse(Console.ReadLine());
            int[] arrayOfNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int pivot = arrayOfNumbers[0];

            Partition(arrayOfNumbers, pivot, sizeOfArray);
        }
    }
}
