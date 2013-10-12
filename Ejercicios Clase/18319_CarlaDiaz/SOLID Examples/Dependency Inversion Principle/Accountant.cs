using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Accountant
    {
        public string name;
        public decimal salary;
        public decimal bankAccount;

        public void Work()
        {
            //cpunt
        }
        public void ReceiveMoney()
        {
            bankAccount += salary;
        }
    }
}
