using System;
using System.Collections.Generic;
using System.Linq;

namespace ClimbingTheLeaderboard
{
    public class Startup
    {
        private static int[] ClimbingLeaderboard(int numberOfPlayers, int[] scores, int numberOfLevelsAliceBeats, int[] valuesOfAlice)
        {
            int[] results = new int[numberOfLevelsAliceBeats];
            Stack<int> leaderboard = new Stack<int>();

            for (int i = 0; i < numberOfPlayers; i++)
            {
                if (leaderboard.Count == 0 || leaderboard.Peek() != scores[i])
                {
                    leaderboard.Push(scores[i]);
                }
            }

            for (int i = 0; i < numberOfLevelsAliceBeats; i++)
            {
                while (leaderboard.Count > 0 && valuesOfAlice[i] >= leaderboard.Peek())
                {
                    leaderboard.Pop();
                }

                results[i] = leaderboard.Count() + 1;
            }

            return results;
        }

        public static void Main()
        {
            int numberOfPlayers = int.Parse(Console.ReadLine());
            int[] scores = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int numberOfLevelsAliceBeats = int.Parse(Console.ReadLine());
            int[] valuesOfAlice = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[] results = ClimbingLeaderboard(numberOfPlayers, scores, numberOfLevelsAliceBeats, valuesOfAlice);
            for (int i = 0; i < results.Length; i++)
            {
                Console.WriteLine(results[i]);
            }
        }
    }
}
