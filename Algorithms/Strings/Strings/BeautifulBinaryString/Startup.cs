using System;

namespace BeautifulBinaryString
{
    public class Startup
    {
        private static int StepsToBeaurifulBinaryString(string sequence, int lengthOfSequence)
        {
            int steps = 0;
            string substring = "010";

            for (int i = 0; i + 3 <= lengthOfSequence; i++)
            {
                string substringOfSequence = sequence.Substring(i, 3);

                if (substringOfSequence == substring)
                {
                    i += 2;
                    steps++;
                }
            }

            return steps;
        }

        public static void Main()
        {
            int lengthOfSequence = int.Parse(Console.ReadLine());
            string sequence = Console.ReadLine();

            int stepsToBeaurifulBinaryString = StepsToBeaurifulBinaryString(sequence, lengthOfSequence);
            Console.WriteLine(stepsToBeaurifulBinaryString);
        }
    }
}
