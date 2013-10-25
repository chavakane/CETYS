using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    class Document : IReportOperation
    {
        public void createData()
        {
            Console.WriteLine("Created some data, yo");
        }

        public Document()
        {
        }

    }
}
