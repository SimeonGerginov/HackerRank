using System;
using System.Text;

namespace Encryption
{
    public class Startup
    {
        private static string Encrypt(string sentence)
        {
            int length = sentence.Length;
            int sqrtOtLength = (int)Math.Sqrt(length);
            int rows = sqrtOtLength;
            int counter = 0;

            int cols;
            int numberOfElementsToTake;

            if (rows * rows == length)
            {
                cols = rows;
                numberOfElementsToTake = cols;
            }
            else
            {
                cols = sqrtOtLength + 1;
                numberOfElementsToTake = cols;
            }

            string[] grid = new string[rows];

            for (int row = 0; row < rows; row++)
            {
                if (counter + numberOfElementsToTake >= sentence.Length)
                {
                    numberOfElementsToTake = sentence.Length - counter;
                }

                grid[row] = sentence.Substring(counter, numberOfElementsToTake);
                counter += numberOfElementsToTake;
            }

            string remainder = "";

            if (sentence.Length - counter > 0)
            {
                remainder = sentence.Substring(counter, sentence.Length - counter);
            }

            StringBuilder sb = new StringBuilder();

            for (int col = 0; col < cols; col++)
            {
                for (int rowGrid = 0; rowGrid < grid.Length; rowGrid++)
                {
                    string word = grid[rowGrid];
                    
                    if (col < word.Length)
                    {
                        char letter = word[col];
                        sb.Append(letter);
                    }
                }

                if (remainder != "" && col < remainder.Length)
                {
                    sb.Append(remainder[col]);
                }

                sb.Append(' ');
            }

            return sb.ToString().TrimEnd();
        }

        public static void Main()
        {
            // wclwfoznbmyycxvaxagjhtexdkwjqhlojykopldsxesbbnezqmixfpujbssrbfhlgubvfhpfliimvmnny
            // wmgjpnull cyjqlejgi lyhhdzbui wctlsqsbm fxeoxmsvv ovxjeirfm zadysxbhn nxkkbffpn bawobphfy
            string sentence = Console.ReadLine();
            string encryptedSentence = Encrypt(sentence);

            Console.WriteLine(encryptedSentence);
        }
    }
}
