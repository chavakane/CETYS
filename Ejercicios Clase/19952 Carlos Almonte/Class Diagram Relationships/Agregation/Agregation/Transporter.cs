using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agregation
{
    class Transporter : Driver
    {
        public Transporter(string name)
        {
            base.Name = name;
        }
    }
}
