namespace assigment_vendingmachine
{
  class CoinPayment : Payment
  {
    public CoinPayment()
    {
    }

    public override bool validatePayment(int amount)
    {
      // replace this bogus check with your real life check!
      int coinsCounted = 0;
      while (coinsCounted < amount)
      {
        coinsCounted++;
      }
      if (coinsCounted == amount)
      {
        return true;
      }
      else
        return false;
    }
  }
}