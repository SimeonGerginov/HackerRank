using System;
using System.Linq;

namespace StringConstruction
{
    public class Startup
    {
        private static int FindMinimumCost(string currentString)
        {
            return currentString
                .GroupBy(c => c)
                .Count();
        }

        public static void Main()
        {
            int numberOfStrings = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfStrings; i++)
            {
                string currentString = Console.ReadLine();
                int minimumCost = FindMinimumCost(currentString);

                Console.WriteLine(minimumCost);
            }
        }
    }
}
