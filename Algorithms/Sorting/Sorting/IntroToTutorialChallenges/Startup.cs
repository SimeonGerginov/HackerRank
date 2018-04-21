using System;

namespace IntroToTutorialChallenges
{
    public class Startup
    {
        public static void Main()
        {
            string number = Console.ReadLine();
            int size = int.Parse(Console.ReadLine());
            string[] arrayOfNumbers = Console.ReadLine().Split(' ');

            int indexOfNumber = Array.IndexOf(arrayOfNumbers, number);
            Console.WriteLine(indexOfNumber);
        }
    }
}
