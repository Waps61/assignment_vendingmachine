using System;

namespace assigment_vendingmachine
{
    public interface IProductSelector
    {
        string ShowKeyboard();
        string ReadSelection();
    }
    public interface IStockManager
    {
        string ShowStock();
    }

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
            Console.WriteLine("Welcome to VendingMachine V " + version);
            Console.WriteLine(productSelector.ShowKeyboard());
            Console.WriteLine(stockManager.ShowStock());
            Console.WriteLine("Select a product...");
            Console.WriteLine("Selected : " + productSelector.ReadSelection());
        }
    }
}