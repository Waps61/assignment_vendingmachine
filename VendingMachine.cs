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
      string selected="";
      Console.WriteLine("Welcome to VendingMachine V "+ version);
      Console.WriteLine(myProductSelector.showKeyboard());
      Console.WriteLine(myStockMananger.showStock());
      Console.WriteLine("Select a product...");
      selected=myProductSelector.readSelection();
      Console.WriteLine("Selected : "+selected);
      Console.WriteLine( "Selected product :" + myStockMananger.getSelectedProductName(selected));
    }
  }
}