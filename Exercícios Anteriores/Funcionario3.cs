using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Ex1.Entities
{
    class Funcionario3 : IComparable
    {
        public string  Name { get; set; }
        public double Salary { get; set; }

        public Funcionario3(string csvEmployee)
        {
            string[] vet = csvEmployee.Split(',');
            Name = vet[0];
            Salary = double.Parse(vet[1], CultureInfo.InvariantCulture);
        }
        public override string ToString()
        {
            return Name + ", " + Salary.ToString("F2");
        }

        public int CompareTo(object obj)
        {
            if(!(obj is Funcionario3))
            {
                throw new ArgumentException("Comparing error. bla bla bla");
            }
            Funcionario3 other = obj as Funcionario3;
            //return Name.CompareTo(other.Name);
            return Salary.CompareTo(other.Salary);
        }
    }
}
