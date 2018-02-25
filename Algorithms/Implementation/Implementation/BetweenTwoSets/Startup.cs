using System;
using System.Linq;

namespace BetweenTwoSets
{
    public class Startup
    {
        private static int CountOfNumbersBetweenSets(int[] a, int[] b)
        {
            int result = 0;

            if (a.Max() < b.Min())
            {
                result = Enumerable.Range(a.Max(), (b.Min() - a.Max() + 1))
                           .Where(rangeNumber => a.All(aNumber => rangeNumber % aNumber == 0) &&
                                  b.All(bNumber => bNumber % rangeNumber == 0))
                           .Count();
            }

            return result;
        }

        public static void Main()
        {
            Console.ReadLine();

            int[] a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] b = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int result = CountOfNumbersBetweenSets(a, b);
            Console.WriteLine(result);
        }
    }
}
