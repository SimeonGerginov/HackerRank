using System;
using System.Linq;

namespace SimpleArraySum
{
    public class Startup
    {
        private static int SumOfArrayElements(int[] arr, int n)
        {
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += arr[i];
            }

            return sum;
        }

        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int sum = SumOfArrayElements(arr, n);

            Console.WriteLine(sum);
        }
    }
}
