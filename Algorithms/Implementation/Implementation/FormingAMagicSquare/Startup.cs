namespace FormingAMagicSquare
{
    using System;
    using System.Linq;

    public class Startup
    {
        private static int MinimalCostForMagicMatrix(int[,] matrix)
        {
            int[,,] magicSquares = new int[,,] {
                        {{8, 1, 6}, {3, 5, 7}, {4, 9, 2}},
                        {{6, 1, 8}, {7, 5, 3}, {2, 9, 4}},
                        {{4, 9, 2}, {3, 5, 7}, {8, 1, 6}},
                        {{2, 9, 4}, {7, 5, 3}, {6, 1, 8}},
                        {{8, 3, 4}, {1, 5, 9}, {6, 7, 2}},
                        {{4, 3, 8}, {9, 5, 1}, {2, 7, 6}},
                        {{6, 7, 2}, {1, 5, 9}, {8, 3, 4}},
                        {{2, 7, 6}, {9, 5, 1}, {4, 3, 8}},
                     };
            int cost = int.MaxValue;
            int currentCost = 0;

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        currentCost += Math.Abs(matrix[j, k] - magicSquares[i, j, k]);
                    }
                }

                if (currentCost < cost)
                {
                    cost = currentCost;
                }

                currentCost = 0;
            }

            return cost;
        }

        public static void Main()
        {
            int[,] matrix = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                int[] row = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int j = 0; j < 3; j++)
                {
                    matrix[i, j] = row[j];
                }
            }

            int minimalCost = MinimalCostForMagicMatrix(matrix);
            Console.WriteLine(minimalCost);
        }
    }
}
