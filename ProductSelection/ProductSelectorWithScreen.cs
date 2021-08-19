using System;
using System.Text.RegularExpressions;

namespace assignment_vendingmachine
{
    public class ProductSelectorWithScreen : IProductSelector
    {
        public string ShowInterface()
            => "|------------------------------------|\n" +
               "| Gain Vending Machine               |\n" +
               "| [ A ] [ B ] [ 1 ] [ 2 ] [ 3 ]      |\n" +
               "| [ C ] [ D ] [ 4 ] [ 5 ] [ 7 ]      |\n" +
               "| [ E ] [ F ] [ 7 ] [ 8 ] [ 9 ]      |\n" +
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