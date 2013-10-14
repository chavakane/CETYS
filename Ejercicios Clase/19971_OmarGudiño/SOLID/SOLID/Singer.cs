using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    class Singer : IMusician
    {
        public void Play()
        {
            Console.Write("Sings\n");
        }
    }
}
