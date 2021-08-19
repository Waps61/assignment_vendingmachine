using System;

namespace assigment_vendingmachine
{
    public class ProductSelector : IProductSelector
    {
        private static Button[,] kbdLayout = { {new Button("A"),new Button("B"),new Button("1"),new Button("2"),new Button("3")},
                              {new Button("C"),new Button("D"),new Button("4"),new Button("5"),new Button("6")},
                              {new Button("E"),new Button("F"),new Button("7"),new Button("8"),new Button("9")},
                              {new Button("OK"),new Button("Cancel"),new Button(""),new Button(""),new Button("")}
                            };
        private static Keyboard myKeyboard = new Keyboard(kbdLayout);

        static ConsoleKeyInfo cki = new ConsoleKeyInfo();

        public string ShowKeyboard()
            => myKeyboard.ToString();


        public string ReadSelection()
        {
            string selection = "";

            Console.TreatControlCAsInput = true;
            do
            {
                cki = Console.ReadKey();
                Predicate<Button> b = validKey;
                if (cki.Key != ConsoleKey.Enter)// && Array.Find(kbdLayout, b))
                    selection += cki.KeyChar;


                //Console.Write(cki.Key.ToString());
            } while (cki.Key != ConsoleKey.Enter && cki.Key != ConsoleKey.Escape);
            return selection;
        }
        private static bool validKey(Button obj)
            => obj.GetbtnValue() == "" + cki.KeyChar;
    }
}