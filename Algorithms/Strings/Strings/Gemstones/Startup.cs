using System;
using System.Collections.Generic;
using System.Linq;

namespace Gemstones
{
    public class Startup
    {
        private static int NumberOfTypesOfGemstones(string[] rocks, int numberOfRocks)
        {
            string firstRock = rocks[0];
            IDictionary<char, int> typesOfGemstones = new Dictionary<char, int>();

            for (int i = 0; i < firstRock.Length; i++)
            {
                if (typesOfGemstones.ContainsKey(firstRock[i]))
                {
                    continue;
                }
                else
                {
                    typesOfGemstones.Add(firstRock[i], 1);
                }
            }

            List<char> gemStones = new List<char>(typesOfGemstones.Keys);

            for (int i = 1; i < numberOfRocks; i++)
            {
                string currentRock = rocks[i];
                foreach(var gemstone in gemStones)
                {
                    if (currentRock.Contains(gemstone))
                    {
                        typesOfGemstones[gemstone]++;
                    }
                }
            }

            return typesOfGemstones.Where(t => t.Value == numberOfRocks).Count();
        }

        public static void Main()
        {
            int numberOfRocks = int.Parse(Console.ReadLine());
            string[] rocks = new string[numberOfRocks];

            for (int i = 0; i < numberOfRocks; i++)
            {
                rocks[i] = Console.ReadLine();
            }

            int numberOfTypesOfGemstones = NumberOfTypesOfGemstones(rocks, numberOfRocks);
            Console.WriteLine(numberOfTypesOfGemstones);
        }
    }
}
