/* Copyright © 2021 Gain Automation Technology
* This class handles actual payment process for wireless payments.
* This object lives in the module layer.
*/
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