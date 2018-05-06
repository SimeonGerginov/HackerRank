using System;
using System.Collections.Generic;
using System.Linq;

namespace JimAndTheOrders
{
    public class Startup
    {
        private static IList<int> CustomersOrder(IDictionary<int, int> customers)
        {
            return customers
                .OrderBy(c => c.Value)
                .Select(c => c.Key)
                .ToList();
        }

        public static void Main()
        {
            int numberOfCustomers = int.Parse(Console.ReadLine());
            IDictionary<int, int> customers = new Dictionary<int, int>();

            for (int i = 0; i < numberOfCustomers; i++)
            {
                int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                int orderNumber = input[0];
                int preparationTime = input[1];

                customers.Add(i + 1, orderNumber + preparationTime);
            }

            IList<int> customersOrder = CustomersOrder(customers);
            Console.WriteLine(string.Join(" ", customersOrder));
        }
    }
}
