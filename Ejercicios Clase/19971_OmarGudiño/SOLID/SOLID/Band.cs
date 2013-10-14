using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    class Band
    {
        public void playInstrument(IMusician musician)
        {
            musician.Play();
        }
    }
}
