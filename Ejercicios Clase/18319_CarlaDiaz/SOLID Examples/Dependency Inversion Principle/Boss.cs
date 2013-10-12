using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Boss
    {
        List<IEmployee> employees;

        public void Work()
        {
            employees.ForEach(x => x.Work());
        }
    }
}
