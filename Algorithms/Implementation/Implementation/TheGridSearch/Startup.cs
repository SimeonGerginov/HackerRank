using System;
using System.Collections.Generic;
using System.Linq;

namespace TheGridSearch
{
    public class Startup
    {
        private static void PrintGrid(int[,] grid)
        {
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    Console.Write(grid[i, j]);
                }
                Console.WriteLine();
            }
        }

        private static bool CheckForFoundPattern(int[,] grid, int[,] pattern, int row, int col)
        {
            bool found = true;
            for (int patternRow = 0; patternRow < pattern.GetLength(0); patternRow++)
            {
                for (int patternCol = 0; patternCol < pattern.GetLength(1); patternCol++)
                {
                    if (grid[row + patternRow, col + patternCol] != pattern[patternRow, patternCol])
                    {
                        found = false;
                        break;
                    }
                }

                if (!found)
                {
                    break;
                }
            }

            return found;
        }

        private static bool IsPatternInGrid(int[,] grid, int[,] pattern)
        {
            for (int row = 0; row < grid.GetLength(0) - pattern.GetLength(0) + 1; row++)
            {
                for (int col = 0; col < grid.GetLength(1) - pattern.GetLength(1) + 1; col++)
                {
                    bool found = CheckForFoundPattern(grid, pattern, row, col);

                    if (found)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private static string IsPatternContained(int[,] grid, int[,] patternGrid)
        {
            bool isInGrid = IsPatternInGrid(grid, patternGrid);

            if (isInGrid)
            {
                return "YES";
            }
            else
            {
                return "NO";
            }
        }

        private static string IsPatternContained(string[] grid, string[] patternGrid)
        {
            List<int> rowsOfPatternInGrid = new List<int>();
            int visitedRow = -1;
            int gridRow = 0;
            string answer = "YES";

            for (int patternRow = 0; patternRow < patternGrid.Length; patternRow++)
            {
                string currentPatternRow = patternGrid[patternRow];
                for (int row = gridRow; row < grid.Length; row++)
                {
                    string currentRow = grid[row];
                    if (currentRow.Contains(currentPatternRow) && visitedRow != row)
                    {
                        rowsOfPatternInGrid.Add(row);
                        visitedRow = row;
                        gridRow = row + 1;
                        break;
                    }
                }
            }

            if (rowsOfPatternInGrid.Count != patternGrid.Length)
            {
                answer = "NO";
                return answer;
            }

            for (int i = 0; i < rowsOfPatternInGrid.Count - 1; i++)
            {
                if (rowsOfPatternInGrid[i] != rowsOfPatternInGrid[i + 1] - 1)
                {
                    answer = "NO";
                    return answer;
                }
            }

            return answer;
        }

        public static void Main()
        {
            int testCases = int.Parse(Console.ReadLine());
            for (int i = 0; i < testCases; i++)
            {
                int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                int rows = input[0];
                int cols = input[1];
                int[,] grid = new int[rows, cols];
                // string[] grid = new string[rows];

                for (int currentRow = 0; currentRow < rows; currentRow++)
                {
                    string row = Console.ReadLine();
                    for (int currentCol = 0; currentCol < cols; currentCol++)
                    {
                        grid[currentRow, currentCol] = int.Parse(row[currentCol].ToString());
                    }
                    // grid[currentRow] = row;
                }

                int[] patternInput = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                int patternRows = patternInput[0];
                int patternCols = patternInput[1];
                int[,] patternGrid = new int[patternRows, patternCols];
                // string[] patternGrid = new string[patternRows];

                for (int currentPatternRow = 0; currentPatternRow < patternRows; currentPatternRow++)
                {
                    string patternRow = Console.ReadLine();
                    for (int currentPatternCol = 0; currentPatternCol < patternCols; currentPatternCol++)
                    {
                        patternGrid[currentPatternRow, currentPatternCol] = int.Parse(patternRow[currentPatternCol].ToString());
                    }
                    // patternGrid[currentPatternRow] = patternRow;
                }

                string isPatternContained = IsPatternContained(grid, patternGrid);
                Console.WriteLine(isPatternContained);
            }
        }
    }
}
