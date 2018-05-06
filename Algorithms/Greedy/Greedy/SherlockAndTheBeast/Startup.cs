using System;
using System.Text;

namespace SherlockAndTheBeast
{
    public class Startup
    {
        private static string LargestDecentNumber(int numberOfDigits)
        {
            int tempNumber = numberOfDigits;
            StringBuilder sb = new StringBuilder();

            while (tempNumber % 3 != 0)
            {
                tempNumber -= 5;
            }

            if (tempNumber < 0)
            {
                return "-1";
            }
            else
            {
                sb.Append('5', tempNumber);
                sb.Append('3', numberOfDigits - tempNumber);

                return sb.ToString();
            }
        }

        public static void Main()
        {
            int testCases = int.Parse(Console.ReadLine());
            for (int i = 0; i < testCases; i++)
            {
                int numberOfDigits = int.Parse(Console.ReadLine());
                string largestDecentNumber = LargestDecentNumber(numberOfDigits);

                Console.WriteLine(largestDecentNumber);
            }
        }
    }
}
