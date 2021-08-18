using System;
using System.Threading;

namespace assigment_vendingmachine
{
  public class CoinModule : PaymentModule
  {
    private static CoinPayment myPayment;

    public CoinModule()
    {

    }


    public override bool startTransaction(int amount)
    {
      return false;
    }
  }
}