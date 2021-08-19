namespace assignment_vendingmachine
{
    class Program
    {
        static void Main(string[] args)
        {
            var productSelector = new ProductSelectorWithVoice();
            var stockManager = new StockManager();
            var paymentModule = new CoinPaymentModule();
            var outfeedModule = new SimpleDispenser();
            var vendingMachine = new VendingMachine(productSelector, stockManager, paymentModule, outfeedModule);

            vendingMachine.Run();
        }
    }
}