using System;

namespace MarsExploration
{
    public class Startup
    {
        private static int ChangedCharactersInMessage(string message)
        {
            int changedCharactersInMessage = 0;

            for (int i = 0; i + 2 < message.Length; i += 3)
            {
                if (message[i] != 'S')
                {
                    changedCharactersInMessage++;
                }

                if (message[i + 1] != 'O')
                {
                    changedCharactersInMessage++;
                }

                if (message[i + 2] != 'S')
                {
                    changedCharactersInMessage++;
                }
            }

            return changedCharactersInMessage;
        }

        public static void Main()
        {
            string message = Console.ReadLine();
            int changedCharactersInMessage = ChangedCharactersInMessage(message);

            Console.WriteLine(changedCharactersInMessage);
        }
    }
}
