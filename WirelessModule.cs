/* Copyright © 2021 Gain Automation Technology
* This class represents a module that accepts wireless payments.
* This object lives in the management layer.
*/
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