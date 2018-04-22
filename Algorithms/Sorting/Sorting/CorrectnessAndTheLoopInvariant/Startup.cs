using System;
using System.Linq;

namespace CorrectnessAndTheLoopInvariant
{
    public class Startup
    {
        private static void InsertionSort(int[] arrayOfNumbers, int sizeOfArray)
        {
            for (int i = 1; i < sizeOfArray; i++)
            {
                int j = i;
                while (j > 0 && arrayOfNumbers[j - 1] > arrayOfNumbers[j])
                {
                    int tempNumber = arrayOfNumbers[j - 1];
                    arrayOfNumbers[j - 1] = arrayOfNumbers[j];
                    arrayOfNumbers[j] = tempNumber;
                    j--;
                }
            }

            Console.WriteLine(string.Join(" ", arrayOfNumbers));
        }

        public static void Main()
        {
            int sizeOfArray = int.Parse(Console.ReadLine());
            int[] arrayOfNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            InsertionSort(arrayOfNumbers, sizeOfArray);
        }
    }
}
