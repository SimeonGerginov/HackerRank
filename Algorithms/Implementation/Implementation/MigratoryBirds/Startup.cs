namespace MigratoryBirds
{
    using System;
    using System.Linq;

    public class Startup
    {
        private static int MostOccuringBirdType(int[] numbers, int n)
        {
            int[] arrayOfTypes = new int[6];
            for (int i = 0; i < n; i++)
            {
                arrayOfTypes[numbers[i]]++;
            }

            return arrayOfTypes.ToList().IndexOf(arrayOfTypes.Max());
        }

        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int mostOccuringType = MostOccuringBirdType(numbers, n);
            Console.WriteLine(mostOccuringType);
        }
    }
}
