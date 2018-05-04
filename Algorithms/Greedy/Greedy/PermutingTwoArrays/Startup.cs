using System;
using System.Collections.Generic;
using System.Linq;

namespace PermutingTwoArrays
{
    public class Startup
    {
        private static string IsValidPermutation(IList<int> firstList, IList<int> secondList, int numberOfElements, int relationVariable)
        {
            firstList = firstList.OrderBy(n => n).ToList();
            secondList = secondList.OrderByDescending(n => n).ToList();

            for (int i = 0; i < numberOfElements; i++)
            {
                if (firstList[i] + secondList[i] >= relationVariable)
                {
                    continue;
                }
                else
                {
                    return "NO";
                }
            }

            return "YES";
        }

        public static void Main()
        {
            int numberOfQueries = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfQueries; i++)
            {
                int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                int numberOfElements = input[0];
                int relationVariable = input[1];

                IList<int> firstList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
                IList<int> secondList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

                string result = IsValidPermutation(firstList, secondList, numberOfElements, relationVariable);
                Console.WriteLine(result);
            }
        }
    }
}
