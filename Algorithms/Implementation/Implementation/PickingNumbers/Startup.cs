using System;
using System.Linq;

namespace PickingNumbers
{
    public class Startup
    {
        private static int PickingNumbers(int sizeOfArray, int[] values)
        {
            Array.Sort(values);
            int current = 0;
            int max = int.MinValue;

            for (int i = 0; i < sizeOfArray - 1; i++)
            {
                for (int j = i; j < sizeOfArray; j++)
                {
                    if (Math.Abs(values[j] - values[i]) <= 1)
                    {
                        current++;
                    }
                }

                if (current > max)
                {
                    max = current;
                }

                current = 0;
            }

            return max;
        }

        public static void Main()
        {
            int sizeOfArray = int.Parse(Console.ReadLine());
            int[] values = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int result = PickingNumbers(sizeOfArray, values);
            Console.WriteLine(result);
        }
    }
}
