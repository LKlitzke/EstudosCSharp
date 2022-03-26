using Ex1.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1.Entities
{
    class BrazilTaxService : ITaxService
    {
        public double Tax(double amount)
        {
            return amount >= 100.00 ? amount * 0.15 : amount * 0.2;
        }
    }
}
