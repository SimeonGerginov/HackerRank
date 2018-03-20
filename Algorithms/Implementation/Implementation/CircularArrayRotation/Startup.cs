using System;
using System.Linq;

namespace CircularArrayRotation
{
    public class Startup
    {
        public static void Main()
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int numberOfElements = input[0];
            int numberOfRotations = input[1];
            int queries = input[2];

            int[] values = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < queries; i++)
            {
                int query = int.Parse(Console.ReadLine());
                int indexValue = numberOfElements - (numberOfRotations % numberOfElements) + query;
                int index = indexValue % numberOfElements;

                Console.WriteLine(values[index]);
            }
        }
    }
}
