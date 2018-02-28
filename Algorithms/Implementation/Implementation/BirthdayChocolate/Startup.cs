namespace BirthdayChocolate
{
    using System;
    using System.Linq;

    public class Startup
    {
        private static int CountDifferentWaysToGiveChocolate(int[] pieces, int N, int days, int months)
        {
            int counter = 0;

            for (int i = 0; i < N; i++)
            {
                int sum = pieces.Skip(i).Take(months).Sum();

                if (sum == days)
                {
                    counter++;
                }
            }

            return counter;
        }

        public static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int[] chocolatePieces = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] daysAndMonths = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int days = daysAndMonths[0];
            int months = daysAndMonths[1];

            int countOfDifferentWays = CountDifferentWaysToGiveChocolate(chocolatePieces, N, days, months);
            Console.WriteLine(countOfDifferentWays);
        }
    }
}
