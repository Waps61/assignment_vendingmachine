namespace assigment_vendingmachine
{
    class Program
    {
        static void Main(string[] args)
        {
            var productSelector = new ProductSelector();
            var stockManager = new StockManager();
            var vendingMachine = new VendingMachine(productSelector, stockManager);

            vendingMachine.Start();
        }
    }
}