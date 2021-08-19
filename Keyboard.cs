/* Copyright © 2021 Gain Automation Technology
* This class represents a keyboard for selecting products in the vending machine.
* This object lives in the control layer.
*/
using System;

namespace assigment_vendingmachine
{
  class Keyboard
  {
    Button[,] keyboard = new Button[4, 5];

    public Keyboard()
    {

    }
    public Keyboard(Button[,] layout)
    {
      this.keyboard = layout;
    }

    public override string ToString()
    {
      int i = 0;
      foreach (Button item in keyboard)
      {
        if ( item.GetbtnValue() != "")
        {
          if (i < 4)
          {
            i++;
            Console.Write("[ " + item.GetbtnValue() + " ]");

          }
          else
          {
            i = 0;

            Console.WriteLine("[ " + item.GetbtnValue() + " ]");
          }
        }
      }
      return "";


    }

    internal Button[,] Layout { get => keyboard; set => keyboard = value; }
  }
}