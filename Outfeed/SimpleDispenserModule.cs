using System;
using System.Threading;

namespace assignment_vendingmachine.Outfeed
{
    public class SimpleDispenser : IOutfeedModule
    {
        public void FeedOutProduct(string location)
        {
            Console.Write($"Feeding out product {location}");
            for(int k = 0; k < 3; k++)
            {
                Thread.Sleep(500);
                Console.Write(".");
            }

            Console.WriteLine(" Done!");
            Thread.Sleep(2000);
        }
    }
}
