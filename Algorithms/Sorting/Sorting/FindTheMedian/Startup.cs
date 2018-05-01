using System;

namespace FindTheMedian
{
    public class Startup
    {
        public static void Main()
        {
            int numberOfElements = int.Parse(Console.ReadLine());
            int[] arrayOfNumbers = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            Array.Sort(arrayOfNumbers);
            Console.WriteLine(arrayOfNumbers[numberOfElements / 2]);
        }
    }
}
