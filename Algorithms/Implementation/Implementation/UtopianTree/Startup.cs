using System;

namespace UtopianTree
{
    public class Startup
    {
        private static int HeightOfUtopianTree(int numberOfCycles)
        {
            int initialHeight = 1;

            if (numberOfCycles == 0)
            {
                return 1;
            }

            if (numberOfCycles == 1)
            {
                return 2;
            }

            while(true)
            {
                if (numberOfCycles < 1)
                {
                    break;
                }

                initialHeight *= 2;
                numberOfCycles--;

                if (numberOfCycles >= 1)
                {
                    initialHeight += 1;
                    numberOfCycles--;
                }
            }

            return initialHeight;
        }

        public static void Main()
        {
            int testCases = int.Parse(Console.ReadLine());

            for (int i = 0; i < testCases; i++)
            {
                int numberOfCycles = int.Parse(Console.ReadLine());
                int heightOfUtopianTree = HeightOfUtopianTree(numberOfCycles);
                Console.WriteLine(heightOfUtopianTree);
            }
        }
    }
}
