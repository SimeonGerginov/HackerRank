using System;

namespace SuperReducedString
{
    public class Startup
    {
        private static string ReduceString(string sequenceOfCharacters)
        {
            for (int i = 1; i < sequenceOfCharacters.Length; i++)
            {
                if (sequenceOfCharacters[i] == sequenceOfCharacters[i - 1])
                {
                    sequenceOfCharacters = sequenceOfCharacters.Substring(0, i - 1) + sequenceOfCharacters.Substring(i + 1);
                    i = 0;
                }
            }

            if (sequenceOfCharacters.Length == 0)
            {
                return "Empty String";
            }
            else
            {
                return sequenceOfCharacters;
            }
        }

        public static void Main()
        {
            string sequenceOfCharacters = Console.ReadLine();
            string reducedString = ReduceString(sequenceOfCharacters);

            Console.WriteLine(reducedString);
        }
    }
}
