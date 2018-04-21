using System;
using System.Linq;

namespace InsertionSortPart1
{
    public class Startup
    {
        private static void InsertionSort(int[] numbers, int sizeOfArray)
        {
            int unsortedElement = numbers[sizeOfArray - 1];
            for (int i = sizeOfArray - 2; i >= 0; i--)
            {
                if (numbers[i] > unsortedElement)
                {
                    numbers[i + 1] = numbers[i];
                    Console.WriteLine(string.Join(" ", numbers));
                }
                else
                {
                    numbers[i + 1] = unsortedElement;
                    Console.WriteLine(string.Join(" ", numbers));
                    break;
                }
            }

            if (!numbers.Contains(unsortedElement))
            {
                numbers[0] = unsortedElement;
                Console.WriteLine(string.Join(" ", numbers));
            }
        }

        public static void Main()
        {
            int sizeOfArray = int.Parse(Console.ReadLine());
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            InsertionSort(numbers, sizeOfArray);
        }
    }
}
