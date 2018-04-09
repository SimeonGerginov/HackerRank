using System;
using System.Collections.Generic;
using System.Linq;

namespace AbsolutePermutation
{
    public class Startup
    {
        private static List<int> AbsolutePermutations(int n, int k)
        {
            List<int> absolutePermutations = new List<int>();

            if (k == 0)
            {
                for (int i = 1; i <= n; i++)
                {
                    absolutePermutations.Add(i);
                }
            }
            else if (n % (2 * k) != 0)
            {
                absolutePermutations.Add(-1);
            }
            else
            {
                bool shouldAdd = true;
                for (int i = 1; i <= n; i++)
                {
                    if (shouldAdd)
                    {
                        absolutePermutations.Add(i + k);
                    }
                    else
                    {
                        absolutePermutations.Add(i - k);
                    }

                    if (i % k == 0)
                    {
                        if (shouldAdd)
                        {
                            shouldAdd = false;
                        }
                        else
                        {
                            shouldAdd = true;
                        }
                    }
                }
            }

            return absolutePermutations;
        }

        public static void Main()
        {
            int testCases = int.Parse(Console.ReadLine());
            for (int i = 0; i < testCases; i++)
            {
                int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                int n = input[0];
                int k = input[1];

                List<int> absolutePermutations = AbsolutePermutations(n, k);
                Console.WriteLine(string.Join(" ", absolutePermutations));
            }
        }
    }
}
