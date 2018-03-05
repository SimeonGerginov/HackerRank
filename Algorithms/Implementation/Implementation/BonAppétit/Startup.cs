namespace BonAppétit
{
    using System;
    using System.Linq;

    public class Startup
    {
        private static void CheckIfChargedMore(int[] costs, int n, int k, int chargedMoney)
        {
            int costOfSharedItems = costs.Sum() - costs[k];
            int costForSinglePerson = costOfSharedItems / 2;

            if (costForSinglePerson == chargedMoney)
            {
                Console.WriteLine("Bon Appetit");
            }
            else
            {
                Console.WriteLine(chargedMoney - costForSinglePerson);
            }
        }

        public static void Main()
        {
            int[] nk = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = nk[0];
            int k = nk[1];

            int[] costsOfItems = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int chargedMoney = int.Parse(Console.ReadLine());

            CheckIfChargedMore(costsOfItems, n, k, chargedMoney);
        }
    }
}
