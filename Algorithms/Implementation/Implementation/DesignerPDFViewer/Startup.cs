using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignerPDFViewer
{
    public class Startup
    {
        private static int FindAreaOfTheRectangle(int[] heights, string word)
        {
            Dictionary<char, int> dictionary = new Dictionary<char, int>();
            char[] letters = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

            for (int i = 0; i < heights.Length; i++)
            {
                char currentLetter = letters[i];
                dictionary[currentLetter] = heights[i];
            }

            int maxHeight = int.MinValue;
            for (int i = 0; i < word.Length; i++)
            {
                char currentLetter = word[i];
                int letterHeight = dictionary[currentLetter];

                if (letterHeight >= maxHeight)
                {
                    maxHeight = letterHeight;
                }
            }

            int area = maxHeight * word.Length;

            return area;
        }

        public static void Main()
        {
            int[] heights = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string word = Console.ReadLine();

            int foundArea = FindAreaOfTheRectangle(heights, word);
            Console.WriteLine(foundArea);
        }
    }
}
