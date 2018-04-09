using System;
using System.Linq;

namespace TheBombermanGame
{
    public class Startup
    {
        private static void PrintGrid(char[,] grid, int rows, int cols)
        {
            for (int currentRow = 0; currentRow < rows; currentRow++)
            {
                for (int currentCol = 0; currentCol < cols; currentCol++)
                {
                    Console.Write(grid[currentRow, currentCol]);
                }

                Console.WriteLine();
            }
        }

        private static char[,] GridAfterEvenSeconds(int rows, int cols)
        {
            char[,] grid = new char[rows, cols];

            for (int currentRow = 0; currentRow < rows; currentRow++)
            {
                for (int currentCol = 0; currentCol < cols; currentCol++)
                {
                    grid[currentRow, currentCol] = 'O';
                }
            }

            return grid;
        }

        private static char[,] GridAfterSeconds(char[,] grid, int rows, int cols)
        {
            for (int currentRow = 0; currentRow < rows; currentRow++)
            {
                for (int currentCol = 0; currentCol < cols; currentCol++)
                {
                    char currentCell = grid[currentRow, currentCol];

                    if (currentCell == 'O')
                    {
                        grid[currentRow, currentCol] = ',';
                    }
                    else
                    {
                        grid[currentRow, currentCol] = 'O';
                    }
                }
            }

            for (int currentRow = 0; currentRow < rows; currentRow++)
            {
                for (int currentCol = 0; currentCol < cols; currentCol++)
                {
                    char currentCell = grid[currentRow, currentCol];

                    if (currentCell == ',')
                    {
                        grid[currentRow, currentCol] = '.';

                        if (currentRow > 0 && grid[currentRow - 1, currentCol] != ',')
                        {
                            grid[currentRow - 1, currentCol] = '.';
                        }

                        if (currentRow < rows - 1 && grid[currentRow + 1, currentCol] != ',')
                        {
                            grid[currentRow + 1, currentCol] = '.';
                        }

                        if (currentCol > 0 && grid[currentRow, currentCol - 1] != ',')
                        {
                            grid[currentRow, currentCol - 1] = '.';
                        }

                        if (currentCol < cols - 1 && grid[currentRow, currentCol + 1] != ',')
                        {
                            grid[currentRow, currentCol + 1] = '.';
                        }
                    }
                }
            }

            return grid;
        }

        private static char[,] GridStateAfterNSeconds(char[,] grid, int rows, int cols, long seconds)
        {
            if (seconds == 1)
            {
                return grid;
            }
            else if (seconds % 2 == 0)
            {
                char[,] newGrid = GridAfterEvenSeconds(rows, cols);

                return newGrid;
            }
            else
            {
                while (true)
                {
                    if (seconds == 3 || seconds == 5)
                    {
                        break;
                    }

                    seconds -= 4;
                }

                if (seconds == 3)
                {
                    // after 3, 7, 11 and ... seconds
                    char[,] newGrid = GridAfterSeconds(grid, rows, cols);

                    return newGrid;
                }
                else
                {
                    // seconds == 5
                    // after 5, 9, 14 and ... seconds
                    char[,] gridAfterThreeSeconds = GridAfterSeconds(grid, rows, cols);
                    char[,] newGrid = GridAfterSeconds(gridAfterThreeSeconds, rows, cols);

                    return newGrid;
                }
            }
        }

        public static void Main()
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rows = input[0];
            int cols = input[1];
            long seconds = (long)input[2];

            char[,] grid = new char[rows, cols];

            for (int currentRow = 0; currentRow < rows; currentRow++)
            {
                string row = Console.ReadLine();
                for (int currentCol = 0; currentCol < cols; currentCol++)
                {
                    grid[currentRow, currentCol] = row[currentCol];
                }
            }

            char[,] gridStateAfterNSeconds = GridStateAfterNSeconds(grid, rows, cols, seconds);

            PrintGrid(gridStateAfterNSeconds, rows, cols);
        }
    }
}
