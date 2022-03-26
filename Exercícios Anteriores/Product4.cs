using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1.Entities
{
    class Product4
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product4(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode() + Price.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            if(!(obj is Product4))
            {
                return false;
            }
            Product4 other = obj as Product4;
            return Name.Equals(other.Name) && Price.Equals(other.Price);
        }
    }
}
