using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankClassLibrary
{
    public class SavingsAccount: BankAccount
    {
        public float AnnualInterestRate { get; set; }

        public void DepositMonthlyInterest()
        {

        }

        public override void Withdrawal(decimal amount)
        {
            throw new NotImplementedException();
        }
    }
}
