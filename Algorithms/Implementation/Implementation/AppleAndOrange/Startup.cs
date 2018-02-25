using System;
using System.Linq;

namespace AppleAndOrange
{
    public class Startup
    {
        private static int[] CountApplesAndOranges(int s, int t, int a, int b, int m, int n, int[] apples, int[] oranges)
        {
            int[] countOfApplesAndOranges = new int[2];

            for (int i = 0; i < m; i++)
            {
                int distance = a + apples[i];

                if(distance >= s && distance <= t)
                {
                    countOfApplesAndOranges[0]++;
                }
            }

            for (int i = 0; i < n; i++)
            {
                int distance = b + oranges[i];

                if (distance >= s && distance <= t)
                {
                    countOfApplesAndOranges[1]++;
                }
            }

            return countOfApplesAndOranges;
        }

        public static void Main()
        {
            int[] houseCoordinates = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int s = houseCoordinates[0];
            int t = houseCoordinates[1];

            int[] treesCoordinates = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int a = treesCoordinates[0];
            int b = treesCoordinates[1];

            int[] numberOfFruitsThrown = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int m = numberOfFruitsThrown[0];
            int n = numberOfFruitsThrown[1];

            int[] appleDistances = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] orangesDistances = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[] countOfAppleAndOranges = CountApplesAndOranges(s, t, a, b, m, n, appleDistances, orangesDistances);
            for (int i = 0; i < countOfAppleAndOranges.Length; i++)
            {
                Console.WriteLine(countOfAppleAndOranges[i]);
            }
        }
    }
}
