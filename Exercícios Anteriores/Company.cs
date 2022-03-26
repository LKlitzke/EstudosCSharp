using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1.Entities
{
    class Company : TaxPayer
    {
        public int NumEmpl { get; set; }

        public Company() { }

        public Company(int numEmpl, string name, double anualIncome) : base(name, anualIncome)
        {
            NumEmpl = numEmpl;
        }

        public override double Taxes()
        {
            return NumEmpl > 10 ? AnualIncome * 0.14 : AnualIncome * 0.16;
        }
    }
}
