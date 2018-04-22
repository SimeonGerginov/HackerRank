using System;
using System.Linq;

namespace RunningTimeOfAlgorithms
{
    public class Startup
    {
        private static void InsertionSort(int[] arrayOfNumbers, int sizeOfArray)
        {
            int numberOfShifts = 0;

            for (int i = 1; i < sizeOfArray; i++)
            {
                int j = i;
                while (j > 0 && arrayOfNumbers[j - 1] > arrayOfNumbers[j])
                {
                    int tempNumber = arrayOfNumbers[j - 1];
                    arrayOfNumbers[j - 1] = arrayOfNumbers[j];
                    arrayOfNumbers[j] = tempNumber;
                    j--;

                    numberOfShifts++;
                }
            }

            Console.WriteLine(numberOfShifts);
        }

        public static void Main()
        {
            int sizeOfArray = int.Parse(Console.ReadLine());
            int[] arrayOfNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            InsertionSort(arrayOfNumbers, sizeOfArray);
        }
    }
}
