namespace DayOfTheProgrammer
{
    using System;

    public class Startup
    {
        private static string FindDate(int year)
        {
            int dayOfProgrammer = 256;
            string month = "09";

            if (year <= 1917)
            {
                if (year % 4 == 0)
                {
                    int sumOfDays = 31 + 29 + 31 + 30 + 31 + 30 + 31 + 31;
                    int day = dayOfProgrammer - sumOfDays;
                    string date = $"{day}.{month}.{year}";
                    return date;
                }
                else
                {
                    int sumOfDays = 31 + 28 + 31 + 30 + 31 + 30 + 31 + 31;
                    int day = dayOfProgrammer - sumOfDays;
                    string date = $"{day}.{month}.{year}";
                    return date;
                }
            }
            else if (year == 1918)
            {
                int sumOfDays = 31 + 15 + 31 + 30 + 31 + 30 + 31 + 31;
                int day = dayOfProgrammer - sumOfDays;
                string date = $"{day}.{month}.{year}";
                return date;
            }
            else
            {
                if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
                {
                    int sumOfDays = 31 + 29 + 31 + 30 + 31 + 30 + 31 + 31;
                    int day = dayOfProgrammer - sumOfDays;
                    string date = $"{day}.{month}.{year}";
                    return date;
                }
                else
                {
                    int sumOfDays = 31 + 28 + 31 + 30 + 31 + 30 + 31 + 31;
                    int day = dayOfProgrammer - sumOfDays;
                    string date = $"{day}.{month}.{year}";
                    return date;
                }
            }
        }

        public static void Main()
        {
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine(FindDate(year));
        }
    }
}
