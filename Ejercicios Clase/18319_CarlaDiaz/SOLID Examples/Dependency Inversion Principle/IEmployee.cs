using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    interface IEmployee
    {
        public string name;
        public decimal salary;
        public decimal bankAccount;

        public void Work();
        public void ReceiveMoney();
    }
}
