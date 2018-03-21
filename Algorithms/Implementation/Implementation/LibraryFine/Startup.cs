using System;
using System.Linq;

namespace LibraryFine
{
    public class Startup
    {
        private static int FindFine(int day, int month, int year, int dueDay, int dueMonth, int dueYear)
        {
            if (year > dueYear)
            {
                return 10000;
            }
            else if (month > dueMonth && year == dueYear)
            {
                return 500 * (month - dueMonth);
            }
            else if (day > dueDay && month == dueMonth && year == dueYear)
            {
                return 15 * (day - dueDay);
            }
            else
            {
                return 0;
            }
        }

        public static void Main()
        {
            int[] dateOfReturn = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int day = dateOfReturn[0];
            int month = dateOfReturn[1];
            int year = dateOfReturn[2];

            int[] dateOfDueReturn = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int dueDay = dateOfDueReturn[0];
            int dueMonth = dateOfDueReturn[1];
            int dueYear = dateOfDueReturn[2];

            int fine = FindFine(day, month, year, dueDay, dueMonth, dueYear);
            Console.WriteLine(fine);
        }
    }
}
