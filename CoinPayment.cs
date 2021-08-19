/* Copyright © 2021 Gain Automation Technology
* This class handles actual payment process when payed with coins.
* This object lives in the module layer.
*/
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