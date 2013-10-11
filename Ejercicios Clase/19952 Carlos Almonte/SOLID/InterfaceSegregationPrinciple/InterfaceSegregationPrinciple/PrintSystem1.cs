using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple
{
    interface PrintSystem1
    {
        void ReceiveDocument(string[] doc);
        string PrintDocument();
    }
}
