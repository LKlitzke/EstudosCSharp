using System;
using System.Collections.Generic;
using System.Text;
using Ex1.Services;

namespace Ex1.Services
{
    class PaypalService : IOnlinePaymentServices
    {
        public double PaymentFee(double amount)
        {
            return amount * 0.02;
        }

        public double Interest(double amount, int months)
        {
            return amount * 0.01 * months;
        }
    }
}
