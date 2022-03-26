using System;
using System.Collections.Generic;
using System.Text;
using Ex1.Entities;

namespace Ex1.Services
{
    class RentalService
    {
        public double  PricePerHour { get; set; }
        public double PricePerDay { get; set; }
        private ITaxService _taxService;

        public RentalService(double pricePerHour, double pricePerDay, ITaxService taxService)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
            _taxService = taxService;
        }

        public void processInvoice(CarRental carRental)
        {
            TimeSpan span = carRental.Finish.Subtract(carRental.Start);

            double basicPayment = 0.0;
            if(span.TotalHours <= 12.0)
            {
                basicPayment = PricePerHour * Math.Ceiling(span.TotalHours);
            }
            else
            {
                basicPayment = PricePerDay * Math.Ceiling(span.TotalDays);
            }
            double tax = _taxService.Tax(basicPayment);

            carRental.Invoice = new Invoice(basicPayment, tax);
        }
    }
}
