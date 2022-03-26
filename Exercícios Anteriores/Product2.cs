using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1.Entities
{
    class Product2
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product2() { }

        public Product2(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual string priceTag()
        {
            return Name + " $ " + Price.ToString("F2");
        }
    }
}
