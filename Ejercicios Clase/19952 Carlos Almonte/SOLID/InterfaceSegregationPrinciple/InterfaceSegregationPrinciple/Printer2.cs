using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple
{
    class Printer2 : PrintSystem2
    {
        private string[] document { get; set; }

        public void Receive(string[] doc)
        {
            this.document = doc;
        }

        public string Print()
        {
            //CODE
            return string.Empty;
        }

    }
}
