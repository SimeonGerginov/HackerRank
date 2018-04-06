using System;
using System.Collections.Generic;

namespace HappyLadybugs
{
    public class Startup
    {
        private static bool IsHappy(string board, int numberOfCells)
        {
            bool isHappy = true;
            for (int i = 1; i < numberOfCells - 1; i++)
            {
                if (board[i] == board[i - 1] || board[i] == board[i + 1])
                {
                    continue;
                }
                else
                {
                    isHappy = false;
                    break;
                }
            }

            return isHappy;
        }

        private static string ResultOfGame(string board, int numberOfCells)
        {
            Dictionary<char, int> colors = new Dictionary<char, int>();
            int underscoreCount = 0;

            for (int i = 0; i < numberOfCells; i++)
            {
                if (board[i] == '_')
                {
                    underscoreCount++;
                }
                else
                {
                    if (colors.ContainsKey(board[i]))
                    {
                        colors[board[i]]++;
                    }
                    else
                    {
                        colors.Add(board[i], 1);
                    }
                }
            }

            foreach (var color in colors)
            {
                if (color.Value == 1 && colors.Count > 1)
                {
                    return "NO";
                }
                else if (color.Value == 1 && underscoreCount == 0)
                {
                    return "NO";
                }
                else if (color.Value == 1 && colors.Count == 1)
                {
                    return "NO";
                }
            }

            if (underscoreCount > 0 || IsHappy(board, numberOfCells))
            {
                return "YES";
            }
            else
            {
                return "NO";
            }
        }

        public static void Main()
        {
            int numberOfGames = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfGames; i++)
            {
                int numberOfCells = int.Parse(Console.ReadLine());
                string board = Console.ReadLine();

                string resultOfGame = ResultOfGame(board, numberOfCells);
                Console.WriteLine(resultOfGame);
            }
        }
    }
}
