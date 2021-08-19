using System;

namespace assigment_vendingmachine
{
    public class VendingMachine
    {
        private static readonly string version = "0.1";

       
        private readonly ProductSelector productSelector;
        private readonly StockManager stockManager;
        public VendingMachine(ProductSelector productSelector, StockManager stockManager)
        {
            this.productSelector = productSelector;
            this.stockManager = stockManager;
        }
        public void Start()
        {
            Console.WriteLine("Welcome to VendingMachine V " + version);
            Console.WriteLine(productSelector.showKeyboard());
            Console.WriteLine(stockManager.showStock());
            Console.WriteLine("Select a product...");
            Console.WriteLine("Selected : " + productSelector.readSelection());
        }
    }
}