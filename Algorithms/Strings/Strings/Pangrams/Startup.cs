using System;
using System.Collections.Generic;

namespace Pangrams
{
    public class Startup
    {
        private static string IsPangram(string sentence)
        {
            IDictionary<char, int> letters = new Dictionary<char, int>();
            int lettersInAlphabet = 26;

            foreach (var letter in sentence)
            {
                if (letter == ' ')
                {
                    continue;
                }

                if (letters.ContainsKey(letter))
                {
                    letters[letter]++;
                }
                else
                {
                    letters.Add(letter, 1);
                }
            }

            if (letters.Count == lettersInAlphabet)
            {
                return "pangram";
            }
            else
            {
                return "not pangram";
            }
        }

        public static void Main()
        {
            string sentence = Console.ReadLine().ToLower();
            string isPangram = IsPangram(sentence);

            Console.WriteLine(isPangram);
        }
    }
}
