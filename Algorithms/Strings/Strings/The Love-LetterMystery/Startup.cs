using System;

namespace The_Love_LetterMystery
{
    public class Startup
    {
        private static int StepsToConvertingTheSequence(string sequence)
        {
            int steps = 0;

            for (int i = 0; i < sequence.Length / 2; i++)
            {
                if ((int)sequence[i] != (int)sequence[sequence.Length - i - 1])
                {
                    steps += Math.Abs((int)sequence[i] - (int)sequence[sequence.Length - i - 1]);
                }
            }

            return steps;
        }

        public static void Main()
        {
            int queries = int.Parse(Console.ReadLine());
            for (int i = 0; i < queries; i++)
            {
                string sequence = Console.ReadLine();
                int stepsToConvertingTheSequence = StepsToConvertingTheSequence(sequence);

                Console.WriteLine(stepsToConvertingTheSequence);
            }
        }
    }
}
