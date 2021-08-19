using System;

namespace assigment_vendingmachine
{
    public class VendingMachine
    {
        private static readonly string version = "0.1";

        private readonly IProductSelector productSelector;
        private readonly IStockManager stockManager;
        private readonly IPaymentModule paymentModule;

        public VendingMachine(IProductSelector productSelector, IStockManager stockManager, IPaymentModule paymentModule)
        {
            this.productSelector = productSelector;
            this.stockManager = stockManager;
            this.paymentModule = paymentModule;
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


                if (!stockManager.HasProduct(location))
                {
                    Console.WriteLine($"No product available on {location}");
                    continue;
                }

                var product = stockManager.GetProductInformation(location);
                Console.WriteLine($"Selected Product: {product.Name}");
                if(!paymentModule.StartTransaction(product.Price))
                {
                    Console.WriteLine("Transaction cancelled.");
                    continue;
                }

                Console.WriteLine("Successfully paid!");
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