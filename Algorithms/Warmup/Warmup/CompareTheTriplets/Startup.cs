using System;
using System.Linq;

namespace CompareTheTriplets
{
    public class Startup
    {
        private static int[] CompareTheTriplets(int[] A, int[] B)
        {
            int[] result = new int[2];
            for (int i = 0; i < 3; i++)
            {
                if(A[i] > B[i])
                {
                    result[0]++;
                }
                else if(A[i] < B[i])
                {
                    result[1]++;
                }
            }

            return result;
        }

        public static void Main()
        {
            int[] A = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] B = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] result = CompareTheTriplets(A, B);

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
