using System;
using System.Collections.Generic;

namespace FindDigits
{
    public class Startup
    {
        private static int CountOfDivisorsOfValue(int value)
        {
            int counter = 0;
            int initialValue = value;
            List<int> listOfDigits = new List<int>();

            while (value > 0)
            {
                listOfDigits.Add(value % 10);
                value = value / 10;
            }

            foreach (var digit in listOfDigits)
            {
                if (digit != 0 && initialValue % digit == 0)
                {
                    counter++;
                }
            }

            return counter;
        }

        public static void Main()
        {
            int testCases = int.Parse(Console.ReadLine());
            for (int i = 0; i < testCases; i++)
            {
                int value = int.Parse(Console.ReadLine());
                int countOfDivisorsOfValue = CountOfDivisorsOfValue(value);

                Console.WriteLine(countOfDivisorsOfValue);
            }
        }
    }
}
