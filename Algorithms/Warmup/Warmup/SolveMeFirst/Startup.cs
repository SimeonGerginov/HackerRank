using System;

namespace SolveMeFirst
{
    public class Startup
    {
        private static int SumOfTwoNumbers(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int sum = SumOfTwoNumbers(firstNumber, secondNumber);

            Console.WriteLine(sum);
        }
    }
}
