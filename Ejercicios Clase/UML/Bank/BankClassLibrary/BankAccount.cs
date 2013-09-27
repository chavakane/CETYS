using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankClassLibrary
{
    public abstract class BankAccount
    {
        public Customer Owner { get; set; }
        public decimal Balance { get; set; }

        public void Deposit(decimal amount)
        {
        }

        public abstract void Withdrawal (decimal amount);
    }
}
