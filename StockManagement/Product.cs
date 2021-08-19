namespace assigment_vendingmachine
{
  public class Product
  {
    private int onStock = 1;
    private string name = "";

    private int price = 0;

    public Product( string name, int price, int onStock)
    {
      this.OnStock = onStock;
      this.Name = name;
      this.Price = price;
    }

    public string Name { get => name; set => name = value; }
    public int OnStock { get => onStock; set => onStock = value; }
    public int Price { get => price; set => price = value; }
  }
}