using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1.Entities
{
    class UsedProduct : Product2
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct() { }

        public UsedProduct(string name, double price, DateTime manufDate) : base(name, price)
        {
            Name = name;
            Price = price;
            ManufactureDate = manufDate;
        }

        public override string priceTag()
        {
            return Name + " (used) " + Price.ToString("F2") + " (Manufacture date: " + ManufactureDate.ToString("dd/MM/yyyy") +")";
        }
    }
}
