namespace ElectronicsShop
{
    using System;
    using System.Linq;

    public class Startup
    {
        private static int AmountOfMoneyToSpend(int money, int[] keyboardPrices, int[] usbPrices,
                                                int numberOfKeyboardBrands, int numberOfUSBBrands)
        {
            int amount = -1;

            for (int i = 0; i < numberOfKeyboardBrands; i++)
            {
                for (int j = 0; j < numberOfUSBBrands; j++)
                {
                    if (keyboardPrices[i] + usbPrices[j] <= money)
                    {
                        amount = Math.Max(keyboardPrices[i] + usbPrices[j], amount);
                    }
                }
            }

            return amount;
        }

        public static void Main()
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int money = input[0];
            int numberOfKeyboardBrands = input[1];
            int numberOfUSBBrands = input[2];

            int[] keyboardPrices = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] usbPrices = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int amountSpend = AmountOfMoneyToSpend(money, keyboardPrices, usbPrices, numberOfKeyboardBrands,
                numberOfUSBBrands);
            Console.WriteLine(amountSpend);
        }
    }
}
