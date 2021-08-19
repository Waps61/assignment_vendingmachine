using assignment_vendingmachine.Outfeed;
using assignment_vendingmachine.Payment;
using assignment_vendingmachine.ProductSelection;
using assignment_vendingmachine.StockManagement;

namespace assignment_vendingmachine
{
    class Program
    {
        static void Main()
        {
            var productSelector = new ProductSelectorWithVoice();
            var stockManager = new StockManager();
            var paymentModule = new CardPaymentModule();
            var outfeedModule = new SimpleDispenser();
            var vendingMachine = new VendingMachine(productSelector, stockManager, paymentModule, outfeedModule);

            vendingMachine.Run();
        }
    }
}