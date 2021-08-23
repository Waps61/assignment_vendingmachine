using System;

namespace assigment_vendingmachine
{
  public class ProductSelector
  {
    private static string validKeys = "ABCDEF123456789";
    private static Button[,] kbdLayout = { {new Button("A"),new Button("B"),new Button("1"),new Button("2"),new Button("3")},
                              {new Button("C"),new Button("D"),new Button("4"),new Button("5"),new Button("6")},
                              {new Button("E"),new Button("F"),new Button("7"),new Button("8"),new Button("9")},
                              {new Button("OK"),new Button("Cancel"),new Button(""),new Button(""),new Button("")}
                            };
    private static Keyboard myKeyboard = new Keyboard(kbdLayout);

    static ConsoleKeyInfo cki = new ConsoleKeyInfo();

    public ProductSelector()
    {
    }

    public string showKeyboard()
    {
      return myKeyboard.ToString();

    }

    private static bool validKey(Button obj)
    {
      return obj.GetbtnValue() == "" + cki.KeyChar;
    }

    public string readSelection()
    {
      string selection = "";

      Console.TreatControlCAsInput = true;
      do
      {
        cki = Console.ReadKey();

        if (cki.Key != ConsoleKey.Enter && validKeys.IndexOf(Char.ToUpper(cki.KeyChar)) > -1) selection += Char.ToUpper(cki.KeyChar);

      } while (cki.Key != ConsoleKey.Enter && cki.Key != ConsoleKey.Escape);
      return selection;
    }
  }
}