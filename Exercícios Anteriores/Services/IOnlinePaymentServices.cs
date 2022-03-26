using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1.Services
{
    interface IOnlinePaymentServices
    {
        double PaymentFee(double amount);
        double Interest(double amount, int months);
    }
}
