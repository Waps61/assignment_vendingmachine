namespace assigment_vendingmachine
{
    public interface IStockManager
    {
        string ShowStock();
        bool HasProduct(string location);
        Product GetProductInformation(string location);
        void NotifyProductTaken(string location);
    }
}