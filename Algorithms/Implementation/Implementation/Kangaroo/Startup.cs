using System;
using System.Linq;

namespace Kangaroo
{
    public class Startup
    {
        private static string CanLandAtTheSameLocation(int x1, int v1, int x2, int v2)
        {
            if(v2 > v1)
            {
                return "NO";
            }
            
            if (v1 != v2 && ((x2 - x1) % (v1 - v2) == 0))
            {
                return "YES";
            }

            return "NO";
        }

        public static void Main()
        {
            int[] locationsAndRates = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int x1 = locationsAndRates[0];
            int v1 = locationsAndRates[1];
            int x2 = locationsAndRates[2];
            int v2 = locationsAndRates[3];

            string canLand = CanLandAtTheSameLocation(x1, v1, x2, v2);
            Console.WriteLine(canLand);
        }
    }
}
