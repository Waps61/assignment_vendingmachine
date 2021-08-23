using System;

namespace assigment_vendingmachine
{

  class VendingMachine
  {
    static string version = "1.0";

    static ProductSelector myProductSelector = new ProductSelector();
    static StockManager myStockMananger = new StockManager();



    static Dispencer myDispencer = new Dispencer();

    static void Main(string[] args)
    {
      string selected = "";
      Console.OutputEncoding = System.Text.Encoding.UTF8;  // make sure you can use the € charcter to show up
      Console.WriteLine("Welcome to VendingMachine V " + version);
      Console.WriteLine(myProductSelector.showKeyboard());
      Console.WriteLine(myStockMananger.showStock());
      Console.WriteLine("Select a product...");
      selected = myProductSelector.readSelection();
      Console.WriteLine("Selected : " + selected);
      if (!String.IsNullOrEmpty(selected) && myStockMananger.onStock(selected))
      {
        Console.Write("Selected product :" + myStockMananger.getSelectedProductName(selected));
        Console.WriteLine(" will cost you :{0:C}", myStockMananger.getSelectedProductPrice(selected));
        Console.WriteLine("Select your payment selection C for Coins or W for Wireless....");
        Console.WriteLine("Press C or W to continue");
        ConsoleKeyInfo t_cki = new ConsoleKeyInfo();
        Console.TreatControlCAsInput = true;
        char choice;
        string t = "";
        do
        {
          t_cki = Console.ReadKey();

          choice = t_cki.KeyChar;
          t = "" + (Char.ToUpper(choice));

        } while (t[0] != 'W' && t[0] != 'C');
        if (t == "C")
        {

          CoinModule myCoinModule = new CoinModule();
          if (myCoinModule.startTransaction(myStockMananger.getSelectedProductPrice(selected)))
          {
            if (myDispencer.fetchProduct(myStockMananger.getProductPosition()))
            {
              Console.WriteLine("Here you go/n Enjoy your "+ myStockMananger.getSelectedProductName(selected));
            }
          }
        }
        if (t == "W")
        {
          WirelessModule myWirelessModule = new WirelessModule();
          if (myWirelessModule.startTransaction(myStockMananger.getSelectedProductPrice(selected)))
          {
            if (myDispencer.fetchProduct(myStockMananger.getProductPosition()))
            {
              Console.WriteLine("Here you go/n Enjoy your "+ myStockMananger.getSelectedProductName(selected));
            }
          }
        }

      }
      else Console.WriteLine("Your selected product is invalid or out of stock!");

    }
  }
}