using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankClassLibrary
{
    public class CheckingAccount: BankAccount
    {
        public decimal InsufficientFundsFee { get; set; }
        
        public void ProcessCheck(Check checkToProcess)
        {

        }

        public override void Withdrawal(decimal amount)
        {
            //Implementation of base method Withdrawal.
        }
    }
}
