using System;
using System.Linq;

namespace BeautifulDaysAtTheMovies
{
    public class Startup
    {
        private static int CountOfBeautifulDays(int startOfRange, int endOfRange, int divisor)
        {
            int counter = 0;

            for (int day = startOfRange; day <= endOfRange; day++)
            {
                string reversedDayAsString = new string(day.ToString().Reverse().ToArray());
                reversedDayAsString.TrimStart('0');

                int reversedDay = int.Parse(reversedDayAsString);
                int absoluteDifference = Math.Abs(day - reversedDay);

                if (absoluteDifference % divisor == 0)
                {
                    counter++;
                }
            }

            return counter;
        }

        public static void Main()
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int startOfRange = input[0];
            int endOfRange = input[1];
            int divisor = input[2];

            int countOfBeautifulDays = CountOfBeautifulDays(startOfRange, endOfRange, divisor);
            Console.WriteLine(countOfBeautifulDays);
        }
    }
}
