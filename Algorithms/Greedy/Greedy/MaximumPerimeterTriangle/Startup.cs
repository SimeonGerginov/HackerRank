using System;
using System.Collections.Generic;
using System.Linq;

namespace MaximumPerimeterTriangle
{
    public class Startup
    {
        private static IList<int> SidesOfTriangle(int[] sticks, int numberOfSticks)
        {
            Array.Sort(sticks);
            IList<int> sides = new List<int>();
            int index = numberOfSticks - 3;

            while (index >= 0 && (sticks[index] + sticks[index + 1] <= sticks[index + 2]))
            {
                index--;
            }

            if (index >= 0)
            {
                sides.Add(sticks[index]);
                sides.Add(sticks[index + 1]);
                sides.Add(sticks[index + 2]);

                return sides;
            }
            else
            {
                sides.Add(-1);

                return sides;
            }
        }

        public static void Main()
        {
            int numberOfSticks = int.Parse(Console.ReadLine());
            int[] sticks = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            IList<int> sidesOfTriangle = SidesOfTriangle(sticks, numberOfSticks);
            Console.WriteLine(string.Join(" ", sidesOfTriangle));
        }
    }
}
