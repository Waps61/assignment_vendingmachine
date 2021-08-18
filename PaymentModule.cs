using System;
using System.Threading;

namespace assigment_vendingmachine
{
  public abstract class PaymentModule
  {
    private static bool isActive = false; //Atomic variable to ensure only one payment module to be active 
    public PaymentModule()
    {
      if (!IsActive)
      {
        IsActive = true;

      }
      else
      {
        while (!IsActive)
        {
          Console.WriteLine("Payment module already active...");
          Thread.Sleep(500);
        }
      }
    }

    public static bool IsActive { get => isActive; set => isActive = value; }

    public abstract bool startTransaction(int amount);
    
  }
}