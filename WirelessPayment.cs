namespace assigment_vendingmachine
{
  class WirelessPayment : Payment
  {
    public WirelessPayment()
    {
    }

    public override bool validatePayment(int amount)
    {
      // implement your wireless transaction here
      return true;
    }
  }
}