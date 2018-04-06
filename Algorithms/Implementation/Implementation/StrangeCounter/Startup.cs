using System;

namespace StrangeCounter
{
    public class Startup
    {
        private static long ValueAtAGivenTime(long time)
        {
            long cycle = 3;

            while (time > cycle)
            {
                time -= cycle;
                cycle *= 2;
            }

            return cycle - time + 1;
        }

        public static void Main()
        {
            long time = long.Parse(Console.ReadLine());

            long valueAtAGivenTime = ValueAtAGivenTime(time);
            Console.WriteLine(valueAtAGivenTime);
        }
    }
}
