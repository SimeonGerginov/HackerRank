using System;

namespace CountingSort2
{
    public class Startup
    {
        private const int MaxNumber = 100;

        private static void OutputElementAppearance(int[] arrayOfNumbers, int numberOfItems)
        {
            int[] outputArray = new int[MaxNumber];

            for (int i = 0; i < numberOfItems; i++)
            {
                outputArray[arrayOfNumbers[i]]++;
            }

            for (int i = 0; i < MaxNumber; i++)
            {
                int number = outputArray[i];

                if (number != 0)
                {
                    for (int j = 0; j < number; j++)
                    {
                        Console.Write(i + " ");
                    }
                }
            }

            Console.WriteLine();
        }

        public static void Main()
        {
            int numberOfItems = int.Parse(Console.ReadLine());
            int[] arrayOfNumbers = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            OutputElementAppearance(arrayOfNumbers, numberOfItems);
        }
    }
}
