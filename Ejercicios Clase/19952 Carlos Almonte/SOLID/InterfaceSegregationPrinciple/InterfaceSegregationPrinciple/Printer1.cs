using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple
{
    class Printer1 : PrintSystem1
    {
        public void ReceiveDocument(string[] doc)
        {
            //CODE
        }

        public string PrintDocument()
        {
            //CODE
            return string.Empty;
        }

    }
}
