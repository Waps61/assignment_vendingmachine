using System;

namespace assigment_vendingmachine
{
    internal class StockEntry
    {
        public Product Product { get; private set; }
        public string Location { get; private set; }
        public uint AmountPresent { get; private set; }

        public bool IsEmpty => AmountPresent == 0;

        public StockEntry(Product product, string location, uint amountPresent)
        {
            Product = product;
            Location = location;
            AmountPresent = amountPresent;
        }

        public void NotifyProductRemoved()
        {
            if (IsEmpty)
                throw new Exception($"Not possible to pick product {Product.Name}, it is empty!");

            AmountPresent--;
        }
    }
}