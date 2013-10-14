using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    class Drummer : IMusician
    {
        public void Play()
        {
            Console.Write("Kicks a sick beat\n");
        }
    }
}
