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
      myPayment = new WirelessPayment();

    }


    public override bool startTransaction(int amount)
    {
      Console.WriteLine("Place your wallet in front of the reader..... press enter when done");
      ConsoleKeyInfo cki = new ConsoleKeyInfo();
      Console.TreatControlCAsInput = true;
      do
      {
        cki = Console.ReadKey();



      } while (cki.Key != ConsoleKey.Enter);
      if (myPayment.validatePayment(amount))
      {
        Console.WriteLine("Paymwntr accepted:\nWait while fetching product....");
        return true;
      }
      else return false;
    }
  }
}