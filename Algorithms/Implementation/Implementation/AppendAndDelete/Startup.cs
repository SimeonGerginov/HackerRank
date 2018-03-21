using System;
using System.Text;

namespace AppendAndDelete
{
    public class Startup
    {
        private static string FindCommonSubstring(string first, string second)
        {
            StringBuilder sb = new StringBuilder();
            int minLength = Math.Min(first.Length, second.Length);

            for (int i = 0; i < minLength; i++)
            {
                if (first[i] == second[i])
                {
                    sb.Append(first[i]);
                }
                else
                {
                    break;
                }
            }

            return sb.ToString();
        }

        private static string CanConvert(string initialString, string desiredString, int numberOfOperations)
        {
            string commonSubstring = FindCommonSubstring(initialString, desiredString);
            int deletedSymbolsCount = initialString.Length - commonSubstring.Length;
            int addedSymbolsCount = desiredString.Length - commonSubstring.Length;

            if ((deletedSymbolsCount + addedSymbolsCount) > numberOfOperations)
            {
                return "No";
            }
            else if ((deletedSymbolsCount + addedSymbolsCount) % 2 == numberOfOperations % 2)
            {
                return "Yes";
            }
            else if ((initialString.Length + desiredString.Length) - numberOfOperations < 0)
            {
                return "Yes";
            }
            else
            {
                return "No";
            }
        }

        public static void Main()
        {
            string initialString = Console.ReadLine();
            string desiredString = Console.ReadLine();
            int numberOfOperations = int.Parse(Console.ReadLine());

            string canConvert = CanConvert(initialString, desiredString, numberOfOperations);
            Console.WriteLine(canConvert);
        }
    }
}
