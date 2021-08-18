namespace assigment_vendingmachine
{
  abstract class  Payment
  {
    public Payment()
    {
    }

    public abstract bool validatePayment(int amount);
  }
}