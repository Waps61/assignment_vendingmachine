using System;

namespace assignment_vendingmachine
{
    public class CoinPaymentModule : IPaymentModule
    {
        public bool StartTransaction(int amount)
        {
            Console.WriteLine($"Please pay ${amount} (type coin value then press enter)");

            double remainingAmount = amount;

            while(remainingAmount > 0)
            {
                Console.Write($"Remaining amount ${remainingAmount:0.00}: ");
                var line = Console.ReadLine();
                if (!Double.TryParse(line, out double coinValue))
                    return false;

                remainingAmount -= coinValue;
            }

            return true;
        }
    }
}