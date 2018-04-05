using System;
using System.Linq;

namespace FairRations
{
    public class Startup
    {
        private static int MinimumNumberOfLoaves(ref int[] breadsOfEachPerson, int numberOfPeople)
        {
            int minimumNumberOfLoaves = 0;

            if (breadsOfEachPerson[0] % 2 != 0)
            {
                breadsOfEachPerson[0]++;
                breadsOfEachPerson[1]++;
                minimumNumberOfLoaves += 2;
            }

            for (int i = 1; i < numberOfPeople - 1; i++)
            {
                if (breadsOfEachPerson[i] % 2 != 0)
                {
                    breadsOfEachPerson[i]++;
                    minimumNumberOfLoaves++;

                    if (breadsOfEachPerson[i - 1] % 2 != 0)
                    {
                        breadsOfEachPerson[i - 1]++;
                        minimumNumberOfLoaves++;
                    }
                    else
                    {
                        breadsOfEachPerson[i + 1]++;
                        minimumNumberOfLoaves++;
                    }
                }
            }

            return minimumNumberOfLoaves;
        }

        public static void Main()
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            int[] breadsOfEachPerson = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int minimumNumberOfLoaves = MinimumNumberOfLoaves(ref breadsOfEachPerson, numberOfPeople);

            for (int i = 0; i < numberOfPeople; i++)
            {
                if (breadsOfEachPerson[i] % 2 != 0)
                {
                    Console.WriteLine("NO");
                    return;
                }
            }

            Console.WriteLine(minimumNumberOfLoaves);
        }
    }
}
