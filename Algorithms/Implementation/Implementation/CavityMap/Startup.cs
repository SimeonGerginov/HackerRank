using System;

namespace CavityMap
{
    public class Startup
    {
        private static char[,] MappedMatrix(char[,] matrix, int numberOfRowsAndColumns)
        {
            for (int i = 0; i < numberOfRowsAndColumns; i++)
            {
                for (int j = 0; j < numberOfRowsAndColumns; j++)
                {
                    if (i != 0 && j != 0 && i < numberOfRowsAndColumns - 1 && j < numberOfRowsAndColumns - 1)
                    {
                        if (matrix[i, j - 1] != 'X' && matrix[i, j + 1] != 'X' && matrix[i - 1, j] != 'X' && matrix[i + 1, j] != 'X')
                        {
                            int currentValue = int.Parse(matrix[i, j].ToString());
                            int leftValue = int.Parse(matrix[i, j - 1].ToString());
                            int rightValue = int.Parse(matrix[i, j + 1].ToString());
                            int upperValue = int.Parse(matrix[i - 1, j].ToString());
                            int downValue = int.Parse(matrix[i + 1, j].ToString());

                            if (currentValue > leftValue && currentValue > rightValue && currentValue > upperValue && currentValue > downValue)
                            {
                                matrix[i, j] = 'X';
                            }
                        }
                    }
                }
            }

            return matrix;
        }

        private static void PrintMatrix(char[,] matrix, int numberOfRowsAndColumns)
        {
            for (int i = 0; i < numberOfRowsAndColumns; i++)
            {
                for (int j = 0; j < numberOfRowsAndColumns; j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
        }

        public static void Main()
        {
            int numberOfRowsAndColumns = int.Parse(Console.ReadLine());
            char[,] matrix = new char[numberOfRowsAndColumns, numberOfRowsAndColumns];

            for (int i = 0; i < numberOfRowsAndColumns; i++)
            {
                char[] row = Console.ReadLine().ToCharArray();
                for (int j = 0; j < numberOfRowsAndColumns; j++)
                {
                    matrix[i, j] = row[j];
                }
            }

            char[,] returnedMatrix = MappedMatrix(matrix, numberOfRowsAndColumns);
            PrintMatrix(returnedMatrix, numberOfRowsAndColumns);
        }
    }
}
