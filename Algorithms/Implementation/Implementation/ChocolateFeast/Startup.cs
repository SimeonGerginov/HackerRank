using System;
using System.Linq;

namespace ChocolateFeast
{
    public class Startup
    {
        private static int TotalNumberOfEatenChocolates(int moneyToSpend, int costOfChocolate, int numberOfWrappers)
        {
            int numberOfEatenChocolates = 0;
            int initialMoney = moneyToSpend;

            while (true)
            {
                if (moneyToSpend <= 0 || moneyToSpend - costOfChocolate < 0)
                {
                    break;
                }

                moneyToSpend -= costOfChocolate;
                numberOfEatenChocolates++;
            }

            int wrappers = initialMoney / costOfChocolate;

            if (wrappers == numberOfWrappers)
            {
                numberOfEatenChocolates++;

                return numberOfEatenChocolates;
            }
            else if(wrappers < numberOfWrappers)
            {
                return numberOfEatenChocolates;
            }
            else
            {
                wrappers -= numberOfWrappers;
                wrappers += 1;
                numberOfEatenChocolates++;

                while (true)
                {
                    if (wrappers < numberOfWrappers)
                    {
                        break;
                    }

                    wrappers -= numberOfWrappers;
                    wrappers += 1;
                    numberOfEatenChocolates++;
                }

                return numberOfEatenChocolates;
            }
        }

        public static void Main()
        {
            int testCases = int.Parse(Console.ReadLine());
            for (int i = 0; i < testCases; i++)
            {
                int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                int moneyToSpend = input[0];
                int costOfChocolate = input[1];
                int numberOfWrappers = input[2];

                int totalNumberOfEatenChocolates = TotalNumberOfEatenChocolates(moneyToSpend, costOfChocolate, numberOfWrappers);
                Console.WriteLine(totalNumberOfEatenChocolates);
            }
        }
    }
}
