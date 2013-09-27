using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankClassLibrary
{
    public class CreditAccount : BankAccount
    {
        public float AnnualInterestRate { get; set; }
        public decimal MinimumMonthlyPayment { get; set; }

        public void ChargeMonthlyInterest()
        {

        }

        public override void Withdrawal(decimal amount)
        {            
        }
    }
}
