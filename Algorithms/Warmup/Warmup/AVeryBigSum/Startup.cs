using System;
using System.Linq;

namespace AVeryBigSum
{
    public class Startup
    {
        private static long VeryBigSum(long[] arr, int n)
        {
            long sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += arr[i];
            }

            return sum;
        }

        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            long[] arr = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            long sum = VeryBigSum(arr, n);

            Console.WriteLine(sum);
        }
    }
}
