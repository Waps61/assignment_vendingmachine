using System;

namespace assigment_vendingmachine
{

  class VendingMachine
  {
    static string version = "0.1";

    static ProductSelector myProductSelector = new ProductSelector();
    static StockManager myStockMananger = new StockManager();

    private CoinModule cashModule;

    static void Main(string[] args)
    {
      Console.WriteLine("Welcome to VendingMachine V "+ version);
      Console.WriteLine(myProductSelector.showKeyboard());
      Console.WriteLine(myStockMananger.showStock());
      Console.WriteLine("Select a product...");
      Console.WriteLine("Selected : "+myProductSelector.readSelection());
    }
  }
}