namespace DivisibleSumPairs
{
    using System;
    using System.Linq;

    public class Startup
    {
        private static int CountDivisibleSumPairs(int[] numbers, int n, int k)
        {
            int counter = 0;
            for (int i = 0; i < n - 1; i++)
            {
                int number = numbers[i];
                for (int j = i + 1; j < n; j++)
                {
                    int currentNumber = numbers[j];
                    if ((number + currentNumber) % k == 0)
                    {
                        counter++;
                    }
                }
            }

            return counter;
        }

        public static void Main()
        {
            int[] nk = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = nk[0];
            int k = nk[1];

            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int countOfDivisibleSumPairs = CountDivisibleSumPairs(numbers, n, k);
            Console.WriteLine(countOfDivisibleSumPairs);
        }
    }
}
