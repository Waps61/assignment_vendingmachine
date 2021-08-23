using System;

namespace assigment_vendingmachine
{
  public class StockManager
  {

    private static int ROW = 0;
    private static int COL = 1;
    private static int[,] productPosition = new int[1, 2];
    private static Product[,] stock = {
                                        {new Product("Cola",2,5), new Product("7-up",2,4), new Product("Sinas",2,6), new Product("Cassis",2,5),new Product("H20",1,8)},
                                        {new Product("Mars",1,3), new Product("Snicker",1,4), new Product("Twix",1,6), new Product("Bounty",1,5),new Product("MilkyWay",1,8)},
                                        {new Product("Chips Paprika",1,5), new Product("Chips Naturel",1,4), new Product("Chips Bolognaise",1,6), new Product("Muffin Choco",2,5),new Product("Muffin Rozijn",2,8)}

    };

    public StockManager()
    {
    }


    private void setKeyboardCode(string keyboardCode)
    {
      // rows are indicated by a character and colums are indicated by a number
      // So input B2 or 2B shoul decode to product on row B col 2
      if (Char.IsNumber(keyboardCode, 0))
      {
        productPosition[0, COL] = (int)keyboardCode[0] - 48;
      }
      else productPosition[ROW, 0] = (int)keyboardCode[0] - 65;
      if (Char.IsNumber(keyboardCode, 1))
      {

        productPosition[0, COL] = (int)keyboardCode[1] - 48;
      }
      else productPosition[ROW, 0] = (int)keyboardCode[1] - 65;

    }
    public string showStock()
    {
      foreach (Product item in stock)
      {
        Console.WriteLine("Product name: " + item.Name + " Price :$" + item.Price + " On stock:" + item.OnStock);

      }
      return "";
    }

    public bool onStock(string keyboardCode)
    {
      setKeyboardCode(keyboardCode);
      try
      {
        Product selectedProduct = stock[productPosition[ROW, 0], productPosition[0, COL]];
        return true;

      }
      catch (Exception e)
      {
        Console.WriteLine("INvalid product exception");
        return false;
      }

    }

    public int getSelectedProductPrice(string keyboardCode)
    {

      setKeyboardCode(keyboardCode);
      return stock[productPosition[ROW, 0], productPosition[0, COL]].Price;
    }

    public string getSelectedProductName(string keyboardCode)
    {


      setKeyboardCode(keyboardCode);
      return stock[productPosition[ROW, 0], productPosition[0, COL]].Name;
    }

    public int[,] getProductPosition(){
      return productPosition;
    }
  }
}