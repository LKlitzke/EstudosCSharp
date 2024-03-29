﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem() { }

        public OrderItem(int quantity, double price, Product product)
        {
            this.Quantity = quantity;
            this.Price = price;
            this.Product = product;
        }

        public double SubTotal()
        {
            return Quantity * Price;
        }

        public override string ToString()
        {
            return (Product.Name + ", $ " + Price.ToString("F2") + ", Quantity: " + Quantity + ", SubTotal: " + SubTotal().ToString("F2"));
        }
    }
}
