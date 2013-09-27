using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankClassLibrary
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }

        public void AddBankAcount(BankAccount account)
        {
            //Creates a new bank account for the customer.
        }

        public IEnumerable<BankAccount> GetAllBankAccounts()
        {
            //Returns all the bank accounts of the customer.
            throw new NotImplementedException();
        }
    }
}
