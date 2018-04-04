using System;
using System.Collections.Generic;
using System.Linq;

namespace Lisa_sWorkbook
{
    public class Startup
    {
        private static int NumberOfSpecialProblems(int[] problemsInChapters, int numberOfChapters, int maximumNumberOfProblemsPerPage)
        {
            int numberOfSpecialProblems = 0;
            int currentPage = 1;

            for (int i = 0; i < numberOfChapters; i++)
            {
                int currentChapter = problemsInChapters[i];
                int startOfRange = 1;
                while (true)
                {
                    if (currentChapter <= 0)
                    {
                        break;
                    }

                    List<int> numbers;
                    if (currentChapter > maximumNumberOfProblemsPerPage)
                    {
                        numbers = Enumerable.Range(startOfRange, maximumNumberOfProblemsPerPage).ToList();
                    }
                    else
                    {
                        numbers = Enumerable.Range(startOfRange, currentChapter).ToList();
                    }

                    currentChapter -= maximumNumberOfProblemsPerPage;

                    if (numbers.Contains(currentPage))
                    {
                        numberOfSpecialProblems++;
                    }

                    startOfRange += maximumNumberOfProblemsPerPage;
                    currentPage++;
                }
            }

            return numberOfSpecialProblems;
        }

        public static void Main()
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int numberOfChapters = input[0];
            int maximumNumberOfProblemsPerPage = input[1];

            int[] problemsInChapters = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int numberOfSpecialProblems = NumberOfSpecialProblems(problemsInChapters, numberOfChapters, maximumNumberOfProblemsPerPage);
            Console.WriteLine(numberOfSpecialProblems);
        }
    }
}
