using System;
using System.Collections.Generic;
using System.Linq;

namespace CutTheSticks
{
    public class Startup
    {
        private static List<int> CutOperation(int numberOfSticks, int[] sticks)
        {
            List<int> result = new List<int>();
            List<int> listOfSticks = new List<int>(sticks);

            while (listOfSticks.Count != 0)
            {
                result.Add(listOfSticks.Count);

                int minStick = listOfSticks.Min();
                listOfSticks.RemoveAll(s => s == minStick);

                for (int i = 0; i < listOfSticks.Count; i++)
                {
                    listOfSticks[i] = listOfSticks[i] - minStick;
                }
            }

            return result;
        }

        public static void Main()
        {
            int numberOfSticks = int.Parse(Console.ReadLine());
            int[] sticks = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            List<int> result = CutOperation(numberOfSticks, sticks);
            for (int i = 0; i < result.Count; i++)
            {
                Console.WriteLine(result[i]);
            }
        }
    }
}
