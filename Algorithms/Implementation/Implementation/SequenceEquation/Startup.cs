using System;
using System.Collections.Generic;
using System.Linq;

namespace SequenceEquation
{
    public class Startup
    {
        private static int[] PermutationEquation(int numberOfElements, int[] values)
        {
            int[] result = new int[numberOfElements];
            List<int> list = new List<int>(values);
            int x = 1;

            for (int i = 0; i < numberOfElements; i++)
            {
                int positionOfX = list.IndexOf(x) + 1;
                int y = list.IndexOf(positionOfX) + 1;
                result[i] = y;
                x++;
            }

            return result;
        }

        public static void Main()
        {
            int numberOfElements = int.Parse(Console.ReadLine());
            int[] values = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[] result = PermutationEquation(numberOfElements, values);
            for (int i = 0; i < numberOfElements; i++)
            {
                Console.WriteLine(result[i]);
            }
        }
    }
}
