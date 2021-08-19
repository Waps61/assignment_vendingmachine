using System;
using System.Text.RegularExpressions;

namespace assignment_vendingmachine.ProductSelection
{
    public class ProductSelectorWithVoice : IProductSelector
    {
        public string ShowInterface()
            => "|------------------------------------|\n" +
               "| Gain Vending Machine               |\n" +
               "| This machine is voice operated,    |\n" +
               "| please state your selection loud   |\n" +
               "| and clear!                         |\n" +
               "|------------------------------------|";

        public string ReadSelection()
        {
            var line = Console.ReadLine();

            var regex = new Regex(@"([A-F])([1-9])");
            if (!regex.IsMatch(line))
                throw new Exception($"Invalid input!");

            return line;
        }
    }
}