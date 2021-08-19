namespace assignment_vendingmachine
{
    public interface IPaymentModule
    {
        bool StartTransaction(int amount);
    }
}