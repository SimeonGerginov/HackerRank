namespace BreakingTheRecords
{
    using System;
    using System.Linq;

    public class Startup
    {
        private static int[] countTimesOfBreakingRecord(int[] scores, int N)
        {
            int[] result = new int[2];
            int countOfBreakingBestScore = 0;
            int countOfBreakingWorstScore = 0;
            int currentBestScore = scores[0];
            int currentWorstScore = scores[0];

            for (int i = 1; i < N; i++)
            {
                if (scores[i] > currentBestScore)
                {
                    currentBestScore = scores[i];
                    countOfBreakingBestScore++;
                }

                if(scores[i] < currentWorstScore)
                {
                    currentWorstScore = scores[i];
                    countOfBreakingWorstScore++;
                }
            }

            result[0] = countOfBreakingBestScore;
            result[1] = countOfBreakingWorstScore;
            return result;
        }

        public static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int[] scores = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] result = countTimesOfBreakingRecord(scores, N);

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
