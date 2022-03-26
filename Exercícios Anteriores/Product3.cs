using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1.Entities
{
    class Product3 : IComparable
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product3(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return Name + ", " + Price.ToString("F2");
        }

        public int CompareTo(object obj)
        {
            if(!(obj is Product3))
            {
                throw new ArgumentException("Comparing error: Argument is not a product");
            }
            Product3 other = obj as Product3;
            return Price.CompareTo(other.Price);
        }
    }
}
