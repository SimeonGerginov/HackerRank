using System;
using System.Linq;

namespace MiniMaxSum
{
    public class Startup
    {
        private static long[] MinMaxSum(long[] arr)
        {
            Array.Sort(arr);
            long[] result = new long[2];
            long minSum = arr[0] + arr[1] + arr[2] + arr[3];
            long maxSum = arr[1] + arr[2] + arr[3] + arr[4];

            result[0] = minSum;
            result[1] = maxSum;

            return result;
        }

        public static void Main()
        {
            long[] arr = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            long[] result = MinMaxSum(arr);

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
