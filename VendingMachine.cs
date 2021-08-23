using System;

namespace assigment_vendingmachine
{

  class VendingMachine
  {
    static string version = "0.2";

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
        char choice = '\0';
        do
        {
          t_cki = Console.ReadKey();

          choice = Char.ToUpper(t_cki.KeyChar);

        } while (t_cki.Key != ConsoleKey.Enter);
        switch (choice)
        {
          case 'C':
            CoinModule myCoinModule = new CoinModule();
            if (myCoinModule.startTransaction(myStockMananger.getSelectedProductPrice(selected)))
            {
              if (myDispencer.fetchProduct(myStockMananger.getProductPosition()))
              {
                Console.WriteLine("Here you go/n Enjoy your {s}", myStockMananger.getSelectedProductName(selected));
              }
            }
            break;
          case 'W':
            WirelessModule myWirelessModule = new WirelessModule();
            if (myWirelessModule.startTransaction(myStockMananger.getSelectedProductPrice(selected)))
            {
              if (myDispencer.fetchProduct(myStockMananger.getProductPosition()))
              {
                Console.WriteLine("Here you go/n Enjoy your {s}", myStockMananger.getSelectedProductName(selected));
              }
            }
            break;
          default:
            break;
        }
      }
      else Console.WriteLine("Your selected product is invalid or out of stock!");

    }
  }
}