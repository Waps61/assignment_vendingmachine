using System;

namespace assigment_vendingmachine
{
    public class VendingMachine
    {
        private static readonly string version = "0.1";

        private readonly IProductSelector productSelector;
        private readonly IStockManager stockManager;

        public VendingMachine(IProductSelector productSelector, IStockManager stockManager)
        {
            this.productSelector = productSelector;
            this.stockManager = stockManager;
        }
        public void Start()
        {
            Console.WriteLine("Welcome to VendingMachine V" + version);
            Console.WriteLine(productSelector.ShowInterface());
            Console.WriteLine(stockManager.ShowStock());
            while (true)
            {
                if (!TryReadProductLocation(out string location))
                    continue;


                if (stockManager.HasProduct(location))
                {
                    var product = stockManager.GetProductInformation(location);
                    Console.WriteLine($"Selected Product: {product.Name}");
                    Console.WriteLine($"Please pay ${product.Price}");
                }
                else
                {
                    Console.WriteLine($"No product available on {location}");
                }
            }
        }

        private bool TryReadProductLocation(out string location)
        {
            Console.Write("Select a product: ");
            try
            {
                location = productSelector.ReadSelection();
                Console.WriteLine("Selected : " + location);
                return true;
            }
            catch
            {
                location = null;
                Console.WriteLine($"That is not a valid input.");
                return false;
            }
        }
    }
}