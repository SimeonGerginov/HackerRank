using System;
using System.Collections.Generic;
using System.Linq;

namespace LuckBalance
{
    public class Startup
    {
        private static int MaximumNumberOfLuck(ICollection<int> importantContests, ICollection<int> notImportantContests, 
            int maxNumberOfContestsToLose)
        {
            int maximumNumberOfLuck = 0;
            int contestsToLose = importantContests.Count - maxNumberOfContestsToLose;

            if (contestsToLose <= 0)
            {
                maximumNumberOfLuck += importantContests.Sum() + notImportantContests.Sum();
            }
            else
            {
                importantContests = importantContests.OrderBy(c => c).ToList();
                maximumNumberOfLuck += importantContests.Sum();

                importantContests = importantContests.Take(contestsToLose).ToList();
                maximumNumberOfLuck -= importantContests.Sum() * 2;

                maximumNumberOfLuck += notImportantContests.Sum();
            }

            return maximumNumberOfLuck;
        }

        public static void Main()
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int numberOfContests = input[0];
            int maxNumberOfContestsToLose = input[1];

            ICollection<int> importantContests = new List<int>();
            ICollection<int> notImportantContests = new List<int>();

            for (int i = 0; i < numberOfContests; i++)
            {
                input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                int luckBalance = input[0];
                int importanceRating = input[1];

                if (importanceRating == 1)
                {
                    importantContests.Add(luckBalance);
                }
                else
                {
                    notImportantContests.Add(luckBalance);
                }
            }

            int maximumNumberOfLuck = MaximumNumberOfLuck(importantContests, notImportantContests, maxNumberOfContestsToLose);
            Console.WriteLine(maximumNumberOfLuck);
        }
    }
}
