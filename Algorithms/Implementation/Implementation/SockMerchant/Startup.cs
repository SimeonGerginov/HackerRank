namespace SockMerchant
{
    using System;
    using System.Linq;

    public class Startup
    {
        private static int CountPairsOfMatchingSocks(int[] socks, int n)
        {
            int counter = 0;
            var groups = socks.GroupBy(s => s);

            foreach (var group in groups)
            {
                if (group.Count() % 2 == 0)
                {
                    counter += group.Count() / 2;
                }
                else
                {
                    counter += (group.Count() - 1) / 2;
                }
            }
            
            return counter;
        }

        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] socks = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int countOfMatchingSocks = CountPairsOfMatchingSocks(socks, n);
            Console.WriteLine(countOfMatchingSocks);
        }
    }
}
