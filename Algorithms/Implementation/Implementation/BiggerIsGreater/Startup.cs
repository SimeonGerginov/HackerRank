using System;
using System.Linq;

namespace BiggerIsGreater
{
    public class Startup
    {
        private static string BiggerIsGreater(string word)
        {
            int firstIndex = FindFirstIndex(word);

            if (firstIndex == -1)
            {
                return "no answer";
            }

            int secondIndex = FindSecondIndex(word, firstIndex);

            string wordWithSwappedCharacters = SwapCharactersInWord(word, firstIndex, secondIndex);

            string firstPartOfWord = wordWithSwappedCharacters.Substring(0, firstIndex + 1);
            char[] secondPartOfWord = wordWithSwappedCharacters.Substring(firstIndex + 1, wordWithSwappedCharacters.Length - firstIndex - 1).Reverse().ToArray();

            return firstPartOfWord + new string(secondPartOfWord);
        }

        private static int FindFirstIndex(string word)
        {
            int index = -1;

            for (int i = 0; i < word.Length - 1; i++)
            {
                if (word[i] < word[i + 1])
                {
                    index = i;
                }
            }

            return index;
        }

        private static int FindSecondIndex(string word, int firstIndex)
        {
            int anotherIndex = -1;

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] > word[firstIndex])
                {
                    anotherIndex = i;
                }
            }

            return anotherIndex;
        }

        private static string SwapCharactersInWord(string word, int firstPosition, int secondPosition)
        {
            char[] wordAsCharArray = word.ToCharArray();

            char tempChar = wordAsCharArray[firstPosition]; 
            wordAsCharArray[firstPosition] = wordAsCharArray[secondPosition];
            wordAsCharArray[secondPosition] = tempChar;
           
            return new string(wordAsCharArray);
        }

        public static void Main()
        {
            int testCases = int.Parse(Console.ReadLine());

            for (int i = 0; i < testCases; i++)
            {
                string word = Console.ReadLine();
                string newWord = BiggerIsGreater(word);

                Console.WriteLine(newWord);
            }
        }
    }
}
