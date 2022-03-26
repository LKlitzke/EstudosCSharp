using Ex1.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1.Services
{
    class ContractService
    {
        private IOnlinePaymentServices _onlinePaymentService;

        public ContractService(IOnlinePaymentServices onlinePaymentService)
        {
            _onlinePaymentService = onlinePaymentService;
        }

        public void processContract(Contract contract, int months)
        {
            double basicQuota = contract.TotalValue / months;
            for(int i=1; i<= months; i++)
            {
                DateTime date = contract.Date.AddMonths(i);
                double quota1 = basicQuota + _onlinePaymentService.Interest(basicQuota, i);
                double quota2 = quota1 + _onlinePaymentService.PaymentFee(quota1);
                contract.AddInstallment(new Installment(date, quota2));
            }

        }
    }
}
