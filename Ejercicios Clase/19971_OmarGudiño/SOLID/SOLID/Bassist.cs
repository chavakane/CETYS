using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    class Bassist : IMusician
    {
        public void Play()
        {
            Console.Write("Plays a groovy tune.\n");
        }
    }
}
