/* Copyright © 2021 Gain Automation Technology
* This class represents a coin module that accepts coins for payment.
* This object lives in the management layer.
*/
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