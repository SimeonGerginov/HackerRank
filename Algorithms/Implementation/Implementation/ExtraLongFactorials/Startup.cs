using System;
using System.Numerics;

namespace ExtraLongFactorials
{
    public class Startup
    {
        private static BigInteger FindFactorialOfValue(int value)
        {
            if (value == 0)
            {
                return 1;
            }

            return value * FindFactorialOfValue(value - 1);
        }

        public static void Main()
        {
            int value = int.Parse(Console.ReadLine());
            BigInteger factorialOfValue = FindFactorialOfValue(value);

            Console.WriteLine(factorialOfValue);
        }
    }
}
