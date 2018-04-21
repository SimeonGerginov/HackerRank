using System;

namespace MakingAnagrams
{
    public class Startup
    {
        private static int MinimumNumberOfCharactersToDelete(string firstString, string secondString)
        {
            int commonCharacters = 0;

            if (firstString.Length <= secondString.Length)
            {
                string tempString = secondString;
                for (int i = 0; i < firstString.Length; i++)
                {
                    int indexOfCharacter = tempString.IndexOf(firstString[i]);
                    if (indexOfCharacter > -1)
                    {
                        tempString = tempString.Remove(indexOfCharacter, 1);
                        commonCharacters++;
                    }
                }
            }
            else
            {
                string tempString = firstString;
                for (int i = 0; i < secondString.Length; i++)
                {
                    int indexOfCharacter = tempString.IndexOf(secondString[i]);
                    if (indexOfCharacter > -1)
                    {
                        tempString = tempString.Remove(indexOfCharacter, 1);
                        commonCharacters++;
                    }
                }
            }

            return (firstString.Length - commonCharacters) + (secondString.Length - commonCharacters);
        }

        public static void Main()
        {
            string firstString = Console.ReadLine();
            string secondString = Console.ReadLine();

            int minimumNumberOfCharactersToDelete = MinimumNumberOfCharactersToDelete(firstString, secondString);
            Console.WriteLine(minimumNumberOfCharactersToDelete);
        }
    }
}
