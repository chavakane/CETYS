using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Engineer : IEmployee
    {
        public string name;
        public decimal salary;
        public decimal bankAccount;

        public void Work()
        {
            //think
        }
        public void ReceiveMoney()
        {
            bankAccount += salary;
        }
    }
}
