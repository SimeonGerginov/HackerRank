using System;
using System.Linq;

namespace FunnyString
{
    public class Startup
    {
        private static string IsFunny(string sequence)
        {
            string reverseSequence = new string(Enumerable.Range(1, sequence.Length)
                .Select(i => sequence[sequence.Length - i]).ToArray());

            for (int i = 1; i < sequence.Length; i++)
            {
                int absoluteDifferenceOfSequence = Math.Abs((int)sequence[i] - (int)sequence[i - 1]);
                int absoluteDifferenceOfReverseSequence = Math.Abs((int)reverseSequence[i] - (int)reverseSequence[i - 1]);

                if (absoluteDifferenceOfSequence != absoluteDifferenceOfReverseSequence)
                {
                    return "Not Funny";
                }
            }

            return "Funny";
        }

        public static void Main()
        {
            int numberOfTestCases = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfTestCases; i++)
            {
                string sequence = Console.ReadLine();
                string isFunny = IsFunny(sequence);

                Console.WriteLine(isFunny);
            }
        }
    }
}
