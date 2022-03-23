using System;
using System.Collections.Generic;
using System.Text;

namespace WpfApp2
{
    public class Product
    {
        public Product(string name, string manufacturer, decimal price, int amount)
        {
            Name = name;
            Manufacturer = manufacturer;
            Price = price;
            Amount = amount;

            Description = "Non Description";
        }
        public string Name { get; set; }
        public string Description { get; set; }
        private string Manufacturer { get; set; }
        private decimal Price { get; set; }
        private bool Activity { get; set; }
        private int Amount { get; set; }
        public void AddDescription(string s)
        {
            Description = s;
        }
        public override string ToString()
        {
            return $"{Name}:\n\t{Description}\n\t{Manufacturer}\n\t{Price}$\n\t{Activity} {Amount}";
        }
    }
}
