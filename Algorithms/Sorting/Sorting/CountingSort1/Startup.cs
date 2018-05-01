using System;

namespace CountingSort1
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

            Console.Write(string.Join(" ", outputArray));
        }

        public static void Main()
        {
            int numberOfItems = int.Parse(Console.ReadLine());
            int[] arrayOfNumbers = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            OutputElementAppearance(arrayOfNumbers, numberOfItems);
        }
    }
}
