namespace assigment_vendingmachine
{
  class Button
  {
    private string btnValue1 = null;
    private bool btnPressed = false;

    public bool BtnPressed { get => btnPressed; set => btnPressed = value; }

    public Button(string i_value) => SetbtnValue(i_value);
    public string GetbtnValue()
    {
      return btnValue1;
    }

    public void SetbtnValue(string value)
    {
      btnValue1 = value;
    }
  }
}