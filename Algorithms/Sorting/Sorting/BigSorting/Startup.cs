using System;
using System.Collections.Generic;

namespace BigSorting
{
    public class Startup
    {
        private static int CompareStringNumbers(string firstString, string secondString)
        {
            if (firstString.Length != secondString.Length)
            {
                return firstString.Length - secondString.Length;
            }

            if (firstString == secondString)
            {
                return 0;
            }

            for (int i = 0; i < firstString.Length; i++)
            {
                int digitOfFirstString = firstString[i];
                int digitOfSecondString = secondString[i];

                if (digitOfFirstString == digitOfSecondString)
                {
                    continue;
                }

                return digitOfFirstString - digitOfSecondString;
            }

            return 0;
        }

        public static void Main()
        {
            int testCases = int.Parse(Console.ReadLine());
            List<string> listOfNumbers = new List<string>();

            for (int i = 0; i < testCases; i++)
            {
                listOfNumbers.Add(Console.ReadLine());
            }
            
            listOfNumbers.Sort((n1, n2) => CompareStringNumbers(n1, n2));

            for (int i = 0; i < testCases; i++)
            {
                Console.WriteLine(listOfNumbers[i]);
            }
        }
    }
}
