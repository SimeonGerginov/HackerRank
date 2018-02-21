using System;

namespace Staircase
{
    public class Startup
    {
        private static void Staircase(int N)
        {
            char symbol = '#';
            int symbolCount = 1;
            char spaceSymbol = ' ';
            int spaces = N - 1;

            for (int i = 0; i < N; i++)
            {
                Console.Write(new string(spaceSymbol, spaces));
                Console.Write(new string(symbol, symbolCount));
                Console.WriteLine();

                spaces--;
                symbolCount++;
            }
        }

        public static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            Staircase(N);
        }
    }
}
