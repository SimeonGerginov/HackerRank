using System;
using System.Collections.Generic;

namespace ModifiedKaprekarNumbers
{
    public class Startup
    {
        private static List<int> FindKaprekarNumbersInRange(int startOfRange, int endOfRange)
        {
            List<int> numbers = new List<int>();

            for (int number = startOfRange; number <= endOfRange; number++)
            {
                if (IsKaprekarNumber(number))
                {
                    numbers.Add(number);
                }
            }

            return numbers;
        }

        private static bool IsKaprekarNumber(long number)
        {
            if (number == 1)
            {
                return true;
            }

            long squareOfNumber = number * number;
            int countOfDigits = squareOfNumber.ToString().Length;
            int countOfDigitsOfNumber = number.ToString().Length;

            for (int rightDigits = 1; rightDigits < countOfDigits; rightDigits++)
            {
                long currentParts = (int)Math.Pow(10, rightDigits);

                if (currentParts == number)
                {
                    continue;
                }

                long sum = squareOfNumber / currentParts + squareOfNumber % currentParts;
                int rightPartDigitsCount = countOfDigits - (squareOfNumber / currentParts).ToString().Length;

                if (sum == number && countOfDigitsOfNumber == rightPartDigitsCount)
                {
                    return true;
                }
            }

            return false;
        }

        public static void Main()
        {
            int startOfRange = int.Parse(Console.ReadLine());
            int endOfRange = int.Parse(Console.ReadLine());

            List<int> numbers = FindKaprekarNumbersInRange(startOfRange, endOfRange);

            if (numbers.Count > 0)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
            else
            {
                Console.WriteLine("INVALID RANGE");
            }
        }
    }
}
