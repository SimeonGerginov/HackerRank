using System;
using System.Linq;

namespace PlusMinus
{
    public class Startup
    {
        private static double[] CalculateFractions(int[] arr, int N)
        {
            int positiveElements = 0;
            int negativeElements = 0;
            int zeroElements = 0;

            for (int i = 0; i < N; i++)
            {
                if(arr[i] > 0)
                {
                    positiveElements++;
                }
                else if(arr[i] < 0)
                {
                    negativeElements++;
                }
                else
                {
                    zeroElements++;
                }
            }

            double[] fractions = new double[3];
            fractions[0] = (double)positiveElements / N;
            fractions[1] = (double)negativeElements / N;
            fractions[2] = (double)zeroElements / N;

            return fractions;
        }

        public static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            double[] fractions = CalculateFractions(arr, N);

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("{0:F6}", fractions[i]);
            }
        }
    }
}
