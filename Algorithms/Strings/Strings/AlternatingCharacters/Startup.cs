using System;

namespace AlternatingCharacters
{
    public class Startup
    {
        private static int DeletedCharactersCount(string word)
        {
            int deletedCharacters = 0;

            for (int i = 0; i + 1 < word.Length; i++)
            {
                if (word[i] != word[i + 1])
                {
                    continue;
                }
                else
                {
                    deletedCharacters++;
                }
            }

            return deletedCharacters;
        }

        public static void Main()
        {
            int testCases = int.Parse(Console.ReadLine());
            for (int i = 0; i < testCases; i++)
            {
                string word = Console.ReadLine();
                int deletedCharactersCount = DeletedCharactersCount(word);

                Console.WriteLine(deletedCharactersCount);
            }
        }
    }
}
