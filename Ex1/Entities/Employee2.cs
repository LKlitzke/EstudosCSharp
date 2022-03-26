using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1
{
    class Employee2
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public double Salary { get; set; }

        public Employee2(string name, string email, double salary)
        {
            Name = name;
            Email = email;
            Salary = salary;
        }
    }
}
