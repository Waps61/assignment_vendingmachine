/* Copyright © 2021 Gain Automation Technology
* This base class represents a module that handles a transaction.
* This object lives in the control layer.
*/
namespace assigment_vendingmachine
{
  abstract class Transaction
  {
    public Transaction()
    {
    }

    public abstract bool startTransaction(int amount);
  }
}