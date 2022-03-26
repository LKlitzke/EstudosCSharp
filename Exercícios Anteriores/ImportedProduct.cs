using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1.Entities
{
    class ImportedProduct : Product2
    {
        public double CustomsFee { get; set; }

        public ImportedProduct() { }

        public ImportedProduct(string name, double price, double customsFee) : base(name, price)
        {
            Name = name;
            Price = Price;
            CustomsFee = customsFee;
        }
        public override string priceTag()
        {
            return totalPrice() + " (Customs fee: $ " + CustomsFee +")";
        }
        public double totalPrice()
        {
            return Price + CustomsFee;
        }
    }
}
