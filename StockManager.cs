using System;

namespace assigment_vendingmachine
{
  public class StockManager
  {
   
    

    private static Product[,] stock = {
                                        {new Product("Cola",2,5), new Product("7-up",2,4), new Product("Sinas",2,6), new Product("Cassis",2,5),new Product("H20",1,8)},
                                        {new Product("Mars",1,3), new Product("Snicker",1,4), new Product("Twix",1,6), new Product("Bounty",1,5),new Product("MilkyWay",1,8)},
                                        {new Product("Chips Paprika",1,5), new Product("Chips Naturel",1,4), new Product("Chips Bolognaise",1,6), new Product("Muffin Choco",2,5),new Product("Muffin Rozijn",2,8)}

    };

    public StockManager()
    {
    }

    

    public string showStock()
    {
      foreach (Product item in stock)
      {
        Console.WriteLine("Product name: " + item.Name + " Price :$" + item.Price + " On stock:" + item.OnStock);

      }
      return "";
    }

    public int getSelectedProductPrice( string keyboardCode){

      int r=0,c = 0;
      return stock[r,c].Price;
    }

    public string getSelectedProductName( string keyboardCode){
      int r=0, c = 0;
      return stock[r, c].Name;
    }
  }
}