using System;

namespace CamelCase
{
    public class Startup
    {
        private static int NumberOfWords(string sentence)
        {
            int numberOfWords = 1;

            for (int i = 0; i < sentence.Length; i++)
            {
                if(char.IsUpper(sentence[i]))
                {
                    numberOfWords++;
                }
            }

            return numberOfWords;
        }

        public static void Main()
        {
            string sentence = Console.ReadLine();
            int numberOfWords = NumberOfWords(sentence);

            Console.WriteLine(numberOfWords);
        }
    }
}
