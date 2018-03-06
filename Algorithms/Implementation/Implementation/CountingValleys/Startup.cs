namespace CountingValleys
{
    using System;

    public class Startup
    {
        private static int CountValleys(int numberOfSteps, string steps)
        {
            int counterOfValleys = 0;
            int seaLevel = 0;

            for (int i = 0; i < numberOfSteps; i++)
            {
                if (steps[i] == 'U')
                {
                    seaLevel++;
                }
                else
                {
                    seaLevel--;
                }

                if (seaLevel == 0 && steps[i] == 'U')
                {
                    counterOfValleys++;
                }
            }

            return counterOfValleys;
        }

        public static void Main()
        {
            int numberOfSteps = int.Parse(Console.ReadLine());
            string steps = Console.ReadLine();

            int countValleys = CountValleys(numberOfSteps, steps);
            Console.WriteLine(countValleys);
        }
    }
}
