/* Copyright © 2021 Gain Automation Technology
* This base class validates a payment .
* This object lives in the module layer.
*/
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