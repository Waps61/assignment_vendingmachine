namespace assigment_vendingmachine
{
    public class Product
    {
        public string Name { get; }
        public int Price { get; }
        public Product(string name, int price)
        {
            Name = name;
            Price = price;
        }
    }
}