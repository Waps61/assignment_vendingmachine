using System;
using System.Threading;

namespace assigment_vendingmachine
{
  public class WirelessModule : PaymentModule
  {
    private static WirelessPayment myPayment;

    public WirelessModule()
    {

    }


    public  override bool startTransaction(int amount)
    {
      return false;
    }
  }
}