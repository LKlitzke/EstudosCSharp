using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1.Entities
{
    class Individual : TaxPayer
    {
        public double HealthExp { get; set; }

        public Individual() { }

        public Individual(double healthExp, string name, double anualIncome) : base(name, anualIncome)
        {
            HealthExp = healthExp;
        }

        public override double Taxes()
        {
            double total = AnualIncome < 20000.00 ? AnualIncome * 0.15 : AnualIncome * 0.25;
            return HealthExp == 0.0 ? total : (total - HealthExp * 0.5);
        }
    }
}
