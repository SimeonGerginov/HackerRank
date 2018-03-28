using System;
using System.Linq;

namespace TaumAndB_day
{
    public class Startup
    {
        private static long MinimumAmountOfUnitsToSpend(long blackGifts, long whiteGifts, long xUnits, long yUnits, long zUnits)
        {
            if (blackGifts * xUnits > blackGifts * (yUnits + zUnits))
            {
                return blackGifts * (yUnits + zUnits) + whiteGifts * yUnits;
            }
            else if (whiteGifts * yUnits > whiteGifts * (xUnits + zUnits))
            {
                return blackGifts * xUnits + whiteGifts * (xUnits + zUnits); 
            }
            else
            {
                return blackGifts * xUnits + whiteGifts * yUnits;
            }
        }

        public static void Main()
        {
            int testCases = int.Parse(Console.ReadLine());
            for (int i = 0; i < testCases; i++)
            {
                long[] gifts = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
                long blackGifts = gifts[0];
                long whiteGifts = gifts[1];

                long[] costs = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
                long xUnits = costs[0];
                long yUnits = costs[1];
                long zUnits = costs[2];

                long minimumAmountOfUnitsToSpend = MinimumAmountOfUnitsToSpend(blackGifts, whiteGifts, xUnits, yUnits, zUnits);
                Console.WriteLine(minimumAmountOfUnitsToSpend);
            }
        }
    }
}
