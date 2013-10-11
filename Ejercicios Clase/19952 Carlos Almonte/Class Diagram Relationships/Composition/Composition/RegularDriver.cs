using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition
{
    class RegularDriver : Driver
    {
        public RegularDriver(string name)
        {
            base.Name = name;
        }
    }
}
