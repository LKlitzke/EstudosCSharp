using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1.Entities
{
    class CarRental
    {
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }
        public Vehicle Model { get; set; }
        public Invoice Invoice { get; set; }

        public CarRental(DateTime start, DateTime finish, Vehicle model)
        {
            Start = start;
            Finish = finish;
            Model = model;
            Invoice = null;
        }
    }
}
