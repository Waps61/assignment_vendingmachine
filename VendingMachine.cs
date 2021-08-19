using System;

namespace assigment_vendingmachine
{
    public interface IProductSelector
    {
        string ShowKeyboard();
        string ReadSelection();
    }
    public class VendingMachine
    {
        private static readonly string version = "0.1";

       
        private readonly IProductSelector productSelector;
        private readonly StockManager stockManager;
        public VendingMachine(IProductSelector productSelector, StockManager stockManager)
        {
            this.productSelector = productSelector;
            this.stockManager = stockManager;
        }
        public void Start()
        {
            Console.WriteLine("Welcome to VendingMachine V " + version);
            Console.WriteLine(productSelector.ShowKeyboard());
            Console.WriteLine(stockManager.showStock());
            Console.WriteLine("Select a product...");
            Console.WriteLine("Selected : " + productSelector.ReadSelection());
        }
    }
}