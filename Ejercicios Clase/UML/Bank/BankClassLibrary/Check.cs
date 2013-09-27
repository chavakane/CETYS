using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankClassLibrary
{
    public class Check
    {
        public decimal Amount { get; set; }
        public string CheckNumber { get; set; }
        public string Payee { get; set; }
        public DateTime Date { get; set; }
    }
}
