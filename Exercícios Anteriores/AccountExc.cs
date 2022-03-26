using System;
using System.Collections.Generic;
using System.Text;
using Ex1.Entities.Exceptions;

namespace Ex1.Entities
{
    class AccountExc
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public AccountExc() { }

        public AccountExc(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
        public void Withdraw(double amount)
        {
            if(amount > WithdrawLimit){
                throw new DomainException("Withdraw error: The amount exceeds withdraw limit");
            }
            if(amount > Balance)
            {
                throw new DomainException("Withdraw error: Not enough balance");
            }
            Balance -= amount;
        }
    }
}
