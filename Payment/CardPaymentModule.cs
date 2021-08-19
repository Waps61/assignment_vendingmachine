using System;
using System.Threading;

namespace assignment_vendingmachine.Payment
{
    public class CardPaymentModule : IPaymentModule
    {
        public bool StartTransaction(int amount)
        {
            Console.Write("Please tap your card (type tap): ");
            var line = Console.ReadLine();
            if (line != "tap")
                return false;

            ProcessPayment();
            if(PaymentSuccessful())
            {
                return true;
            }
            else
            {
                Console.WriteLine("Insufficient funds!");
                return false;
            }
        }

        private bool PaymentSuccessful()
        {
            var rnd = new Random();
            return rnd.NextDouble() < 0.8;
        }

        private static void ProcessPayment()
        {
            Console.Write("Processing");
            for (int k = 0; k < 3; k++)
            {
                Thread.Sleep(500);
                Console.Write(".");
            }
            Console.WriteLine(" Done!");
        }
    }
}
