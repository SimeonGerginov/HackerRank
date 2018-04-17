using System;
using System.Text;

namespace HackerRankInAString_
{
    public class Startup
    {
        private static string ContainsHackerRank(string queryString)
        {
            string hackerRank = "hackerrank";
            int startIndex = 0;
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < queryString.Length; i++)
            {
                if (queryString[i] == hackerRank[startIndex])
                {
                    sb.Append(queryString[i]);
                    startIndex++;
                }

                if (sb.Length == hackerRank.Length)
                {
                    break;
                }
            }

            if (sb.ToString() == hackerRank)
            {
                return "YES";
            }
            else
            {
                return "NO";
            }
        }

        public static void Main()
        {
            int queries = int.Parse(Console.ReadLine());
            for (int i = 0; i < queries; i++)
            {
                string queryString = Console.ReadLine();
                string containsHackerRank = ContainsHackerRank(queryString);

                Console.WriteLine(containsHackerRank);
            }
        }
    }
}
