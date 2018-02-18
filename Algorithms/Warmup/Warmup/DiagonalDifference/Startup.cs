using System;
using System.Linq;

namespace DiagonalDifference
{
    public class Startup
    {
        private static int DiagonalDifference(int[,] matrix, int n)
        {
            int primaryDiagonalSum = 0;
            int secondDiagonalSum = 0;

            for (int i = 0; i < n; i++)
            {
                primaryDiagonalSum += matrix[i, i];
                secondDiagonalSum += matrix[n - i - 1, i];
            }

            return Math.Abs(primaryDiagonalSum - secondDiagonalSum);
        } 

        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                int[] row = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = row[j];
                }
            }

            int diagonalDifference = DiagonalDifference(matrix, n);
            Console.WriteLine(diagonalDifference);
        }
    }
}
