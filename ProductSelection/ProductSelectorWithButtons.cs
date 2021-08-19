using System;
using System.Text.RegularExpressions;

namespace assigment_vendingmachine
{
    public class ProductSelectorWithButtons : IProductSelector
    {
        public string ShowKeyboard()
            => "[ A ] [ B ] [ 1 ] [ 2 ] [ 3 ] \n" +
               "[ C ] [ D ] [ 4 ] [ 5 ] [ 7 ] \n" +
               "[ E ] [ F ] [ 7 ] [ 8 ] [ 9 ]";

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