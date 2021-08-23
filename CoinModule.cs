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
      myPayment = new CoinPayment();
    }


    public override bool startTransaction(int amount)
    {
      Console.WriteLine("Insert coins..... press enter when done");
      ConsoleKeyInfo cki = new ConsoleKeyInfo();
      Console.TreatControlCAsInput = true;
      do
      {
        cki = Console.ReadKey();



      } while (cki.Key != ConsoleKey.Enter);
      if (myPayment.validatePayment(amount))
      {
        Console.WriteLine("Payment accepted.\nWait while fetching product....");
        return true;
      }
      else return false;
    }
  }
}