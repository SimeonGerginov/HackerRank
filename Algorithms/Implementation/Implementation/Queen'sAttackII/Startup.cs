using System;
using System.Linq;

namespace Queen_sAttackII
{
    public class Startup
    {
        private static int CalculateSquaresForRow(bool[,] board, int row, int col)
        {
            int result = 0;

            // Calculate squares for right part of row
            for (int currentCol = col + 1; currentCol < board.GetLength(1); currentCol++)
            {
                if (board[row, currentCol])
                {
                    break;
                }

                result++;
            }

            // Calculate squares for left part of row
            for (int currentCol = col - 1; currentCol >= 0; currentCol--)
            {
                if (board[row, currentCol])
                {
                    break;
                }

                result++;
            }

            return result;
        }

        private static int CalculateSquaresForCol(bool[,] board, int row, int col)
        {
            int result = 0;

            // Calculate squares for right part of col
            for (int currentRow = row + 1; currentRow < board.GetLength(0); currentRow++)
            {
                if (board[currentRow, col])
                {
                    break;
                }

                result++;
            }

            // Calculate squares for left part of col
            for (int currentRow = row - 1; currentRow >= 0; currentRow--)
            {
                if (board[currentRow, col])
                {
                    break;
                }

                result++;
            }

            return result;
        }

        private static int CalculateSquaresForMainDiagonal(bool[,] board, int row, int col)
        {
            int result = 0;

            // Calculate bottom half of the main diagonal
            int bottomStartRow = row - 1;
            int bottomStartCol = col + 1;

            while (true)
            {
                if (bottomStartRow < 0)
                {
                    break;
                }

                if (bottomStartCol >= board.GetLength(1))
                {
                    break;
                }

                if (board[bottomStartRow, bottomStartCol])
                {
                    break;
                }

                result++;
                bottomStartRow--;
                bottomStartCol++;
            }

            // Calculate upper half of the main diagonal
            int upperStartRow = row + 1;
            int upperStartCol = col - 1;

            while (true)
            {
                if (upperStartRow >= board.GetLength(0))
                {
                    break;
                }

                if (upperStartCol < 0)
                {
                    break;
                }

                if (board[upperStartRow, upperStartCol])
                {
                    break;
                }

                result++;
                upperStartRow++;
                upperStartCol--;
            }

            return result;
        }

        private static int CalculateSquaresForOtherDiagonal(bool[,] board, int row, int col)
        {
            int result = 0;

            // Calculate bottom half of the other diagonal
            int bottomStartRow = row - 1;
            int bottomStartCol = col - 1;

            while (true)
            {
                if (bottomStartRow < 0)
                {
                    break;
                }

                if (bottomStartCol < 0)
                {
                    break;
                }

                if (board[bottomStartRow, bottomStartCol])
                {
                    break;
                }

                result++;
                bottomStartRow--;
                bottomStartCol--;
            }

            // Calculate upper half of the other diagonal
            int upperStartRow = row + 1;
            int upperStartCol = col + 1;

            while (true)
            {
                if (upperStartRow >= board.GetLength(0))
                {
                    break;
                }

                if (upperStartCol >= board.GetLength(1))
                {
                    break;
                }

                if (board[upperStartRow, upperStartCol])
                {
                    break;
                }

                result++;
                upperStartRow++;
                upperStartCol++;
            }

            return result;
        }

        private static int NumberOfSquaresToAttack(bool[,] board, int row, int col)
        {
            int numberOfSquaresToAttack = 0;

            numberOfSquaresToAttack += CalculateSquaresForRow(board, row, col);
            numberOfSquaresToAttack += CalculateSquaresForCol(board, row, col);
            numberOfSquaresToAttack += CalculateSquaresForMainDiagonal(board, row, col);
            numberOfSquaresToAttack += CalculateSquaresForOtherDiagonal(board, row, col);

            return numberOfSquaresToAttack;
        }

        private static int NumberOfSquaresToAttack(int lengthOfBoard, int numberOfObsticles, int row, int col)
        {
            int numberOfSquaresToAttack = 0;

            // Calculate Distance between queen and edges of the board
            int upDistance = lengthOfBoard - row;
            int downDistance = row - 1;
            int leftDistance = col - 1;
            int rightDistance = lengthOfBoard - col;

            int upRightDistance = lengthOfBoard - Math.Max(row, col);
            int downRightDistance = Math.Min(rightDistance, downDistance);
            int upLeftDistance = Math.Min(upDistance, Math.Abs(1 - col));
            int downLeftDistance = Math.Min(row, col) - 1;

            for (int i = 0; i < numberOfObsticles; i++)
            {
                int[] coordinatesOfObsticle = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                int obsticleRow = coordinatesOfObsticle[0];
                int obsticleCol = coordinatesOfObsticle[1];

                if ((obsticleCol == col && obsticleRow > row) && obsticleRow - row < upDistance)
                {
                    upDistance = obsticleRow - row - 1;
                }
                else if ((obsticleCol == col && obsticleRow < row) && row - obsticleRow < downDistance)
                {
                    downDistance = row - obsticleRow - 1;
                }
                else if ((obsticleRow == row && obsticleCol < col) && col - obsticleCol < leftDistance)
                {
                    leftDistance = col - obsticleCol - 1;
                }
                else if((obsticleRow == row && obsticleCol > col) && obsticleCol - col < rightDistance)
                {
                    rightDistance = obsticleCol - col - 1;
                }
                else if ((obsticleRow > row && obsticleCol > col) && (obsticleRow - row == obsticleCol - col) &&
                    obsticleRow - row < upRightDistance)
                {
                    upRightDistance = obsticleRow - row - 1;
                }
                else if((obsticleRow > row && obsticleCol < col) && (obsticleRow - row == col - obsticleCol) &&
                    obsticleRow - row < upLeftDistance)
                {
                    upLeftDistance = obsticleRow - row - 1; 
                }
                else if((obsticleRow < row && obsticleCol > col) && (row - obsticleRow == obsticleCol - col) &&
                    obsticleCol - col < downRightDistance)
                {
                    downRightDistance = obsticleCol - col - 1;
                }
                else if((obsticleRow < row && obsticleCol < col) && (row - obsticleRow == col - obsticleCol) &&
                    col - obsticleCol < downLeftDistance)
                {
                    downLeftDistance = col - obsticleCol - 1;
                }
            }

            numberOfSquaresToAttack += upDistance + downDistance + leftDistance + rightDistance +
                upRightDistance + upLeftDistance + downRightDistance + downLeftDistance;

            return numberOfSquaresToAttack;
        }

        public static void Main()
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int lengthOfBoard = input[0];
            int numberOfObsticles = input[1];

            //bool[,] board = new bool[lengthOfBoard, lengthOfBoard];

            int[] queenCordinates = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            // int row = queenCoordinates[0] - 1;
            // int col = queenCoordinates[1] - 1;
            int row = queenCordinates[0];
            int col = queenCordinates[1];
            //board[row, col] = true;

            //for (int i = 0; i < numberOfObsticles; i++)
            //{
            //    int[] coordinatesOfObsticle = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            //    int obsticleRow = coordinatesOfObsticle[0] - 1;
            //    int obsticleCol = coordinatesOfObsticle[1] - 1;
            //    //board[obsticleRow, obsticleCol] = true;
            //}

            //int numberOfSquaresToAttack = NumberOfSquaresToAttack(board, row, col);
            int numberOfSquaresToAttack = NumberOfSquaresToAttack(lengthOfBoard, numberOfObsticles, row, col);
            Console.WriteLine(numberOfSquaresToAttack);
        }
    }
}
