/* Copyright © 2021 Gain Automation Technology
* This base class represents a button(key) as part of a keyboard and returns it value when pressed
* This object lives in the device layer.
*/
namespace assigment_vendingmachine
{
  class Button
  {
    private string btnValue = null;
    private bool btnPressed = false;

    public bool BtnPressed { get => btnPressed; set => btnPressed = value; }

    public Button(string i_value) => SetbtnValue(i_value);
    public string GetbtnValue()
    {
      return btnValue;
    }

    public void SetbtnValue(string value)
    {
      btnValue = value;
    }
  }
}