using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace assigment_vendingmachine
{
    public class StockManager : IStockManager
    {
        private static List<StockEntry> stock = new List<StockEntry>()
        {
            new StockEntry(new Product("Cola", 2),"A1", 3),
            new StockEntry(new Product("7-up", 2),"A2", 4),
            new StockEntry(new Product("Sinas", 2), "A3", 3),
            new StockEntry(new Product("Cassis", 2), "A4", 2),
            new StockEntry(new Product("H2O", 1), "A5", 3),
            new StockEntry(new Product("Mars", 1), "B1", 4),
            new StockEntry(new Product("Snicker", 1), "B2", 3),
            new StockEntry(new Product("Twix", 1), "B3", 0),
            new StockEntry(new Product("Bounty", 1), "B4", 4),
            new StockEntry(new Product("MilkyWay", 1), "B5", 1),
            new StockEntry(new Product("Chips Paprika", 1), "C1", 0),
            new StockEntry(new Product("Chips Naturel", 1), "C2", 3),
            new StockEntry(new Product("Chips Bolognaise", 1), "C3", 3),
            new StockEntry(new Product("Muffin Choco", 2), "D1", 1),
            new StockEntry(new Product("Muffin Rozijn", 2), "D2", 2)
        };

        public string ShowStock()
        {
            var sb = new StringBuilder();
            foreach(var entry in stock)
            {
                sb.AppendLine($"{entry.Location}: {entry.AmountPresent} x {entry.Product.Name} (${entry.Product.Price}) ");
            }


            return sb.ToString();
        }

        public int GetProductPrice(string location)
        {
            var stockEntry = FindStockEntry(location);
            return stockEntry.Product.Price;
        }
        public string GetProductName(string location)
        {
            var stockEntry = FindStockEntry(location);
            return stockEntry.Product.Name;
        }

        private static StockEntry FindStockEntry(string location)
        {
            var stockEntry = stock.SingleOrDefault(entry => entry.Location == location);
            if (stockEntry == null)
                throw new Exception("Product not found!");
            return stockEntry;
        }

        public bool HasProduct(string location)
        {
            try
            {
                var entry = FindStockEntry(location);
                return entry.AmountPresent > 0;
            }
            catch
            {
                return false;
            }

        }

        public Product GetProductInformation(string location)
        {
            var entry = FindStockEntry(location);
            return entry.Product;
        }

        public void NotifyProductTaken(string location)
        {
            throw new NotImplementedException();
        }
    }
}