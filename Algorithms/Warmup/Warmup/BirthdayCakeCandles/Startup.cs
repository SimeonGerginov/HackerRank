using System;
using System.Linq;

namespace BirthdayCakeCandles
{
    public class Startup
    {
        private static int CandlesCount(int[] arr, int N)
        {
            int maxCandleHeight = arr.Max();
            int candlesCount = 0;

            for (int i = 0; i < N; i++)
            {
                if (arr[i] == maxCandleHeight)
                {
                    candlesCount++;
                }
            }

            return candlesCount;
        }

        public static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int candlesCount = CandlesCount(arr, N);

            Console.WriteLine(candlesCount);
        }
    }
}
