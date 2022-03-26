using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1
{
    class Product5
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product5(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return Name + ", " + Price.ToString("F2");
        }

        // Implementação para IComparable
        /*public int CompareTo(Product5 other)
        {
            return Price.CompareTo(other.Price);
        }*/

    }
}
