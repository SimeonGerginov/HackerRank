using System;
using System.Linq;

namespace GameOfThrones_I
{
    public class Startup
    {
        private static string IsPalindromeAnagram(string sequence)
        {
            var charCount = sequence.GroupBy(c => c, (c, i) => new
            {
                character = c,
                count = i.Count()
            });

            if (charCount.Count(c => c.count % 2 == 1) <= 1)
            {
                return "YES";
            }
            else
            {
                return "NO";
            }
        }

        public static void Main()
        {
            string sequence = Console.ReadLine();
            string isPalindromeAnagram = IsPalindromeAnagram(sequence);

            Console.WriteLine(isPalindromeAnagram);
        }
    }
}
