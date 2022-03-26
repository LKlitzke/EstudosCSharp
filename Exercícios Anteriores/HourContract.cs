using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1.Entities
{
    class HourContract
    {
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public double Hours { get; set; }

        public HourContract(DateTime date, double value, double hours)
        {
            Date = date;
            ValuePerHour = value;
            Hours = hours;
        }

        public double totalValue()
        {
            return ValuePerHour * Hours;
        }
    }
}
