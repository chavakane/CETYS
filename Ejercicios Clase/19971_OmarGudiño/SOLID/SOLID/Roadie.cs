using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    class Roadie : ICrew
    {
        public void Travel()
        {
            Console.WriteLine("Travel with the band!");
        }
    }
}
