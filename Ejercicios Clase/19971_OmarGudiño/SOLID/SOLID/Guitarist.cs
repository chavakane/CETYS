using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    class Guitarist : IMusician
    {
        public void Play()
        {
            Console.Write("Plays awesome Solo\n");
        }
    }
}
