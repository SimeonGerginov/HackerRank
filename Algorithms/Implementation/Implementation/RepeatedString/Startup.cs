using System;

namespace RepeatedString
{
    public class Startup
    {
        private static long CountNumberOfLettersAInString(string word, long count)
        {
            long counter = 0;
            int letterAInWord = 0;
            long remainder = 0;

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'a')
                {
                    letterAInWord++;
                }
            }

            for (int i = 0; i < count % word.Length; i++)
            {
                if (word[i] == 'a')
                {
                    remainder++;
                }
            }

            counter += (count / word.Length) * letterAInWord + remainder;

            return counter;
        }

        public static void Main()
        {
            string word = Console.ReadLine();
            long count = long.Parse(Console.ReadLine());

            long countNumberOfLettersAInString = CountNumberOfLettersAInString(word, count);
            Console.WriteLine(countNumberOfLettersAInString);
        }
    }
}
