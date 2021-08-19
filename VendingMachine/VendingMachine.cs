using System;

namespace assignment_vendingmachine
{
    public class VendingMachine
    {
        private static readonly string version = "0.1";

        private readonly IProductSelector productSelector;
        private readonly IStockManager stockManager;
        private readonly IPaymentModule paymentModule;
        private readonly IOutfeedModule outfeedModule;

        public VendingMachine(IProductSelector productSelector, IStockManager stockManager, IPaymentModule paymentModule, IOutfeedModule outfeedModule)
        {
            this.productSelector = productSelector;
            this.stockManager = stockManager;
            this.paymentModule = paymentModule;
            this.outfeedModule = outfeedModule;
        }
        public void Run()
        {
            while (true)
            {
                ShowInterface();

                if (!TryReadProductLocation(out string location))
                    continue;


                if (!stockManager.HasProduct(location))
                {
                    Console.WriteLine($"No product available on {location}");
                    Console.ReadLine();
                    continue;
                }

                var product = stockManager.GetProductInformation(location);
                Console.WriteLine($"Selected Product: {product.Name}");
                if (!paymentModule.StartTransaction(product.Price))
                {
                    Console.WriteLine("Transaction cancelled.");
                    Console.ReadLine();
                    continue;
                }
                Console.WriteLine("Successfully paid!");

                outfeedModule.FeedOutProduct(location);
                stockManager.NotifyProductTaken(location);
            }
        }

        private void ShowInterface()
        {
            Console.Clear();
            Console.WriteLine("Welcome to VendingMachine V" + version);
            Console.WriteLine(productSelector.ShowInterface());
            Console.WriteLine(stockManager.ShowStock());
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
                Console.ReadLine();
                return false;
            }
        }
    }
}