using System;

namespace Anagram
{
    public class Startup
    {
        private static int MinimumNumberOfChanges(string currentWord)
        {
            string leftPart = currentWord.Substring(0, currentWord.Length / 2);
            string rightPart = currentWord.Substring(currentWord.Length / 2);

            if (leftPart.Length != rightPart.Length)
            {
                return -1;
            }

            int commonCharacters = 0;

            string tempString = rightPart;
            for (int i = 0; i < leftPart.Length; i++)
            {
                int indexOfCharacter = tempString.IndexOf(leftPart[i]);
                if (indexOfCharacter > -1)
                {
                    tempString = tempString.Remove(indexOfCharacter, 1);
                    commonCharacters++;
                }
            }

            return leftPart.Length - commonCharacters;
        }

        public static void Main()
        {
            int testCases = int.Parse(Console.ReadLine());
            for (int i = 0; i < testCases; i++)
            {
                string currentWord = Console.ReadLine();

                int minimumNumberOfChanges = MinimumNumberOfChanges(currentWord);
                Console.WriteLine(minimumNumberOfChanges);
            }
        }
    }
}
