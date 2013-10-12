using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class AmericanPerson : Person, ICleanPerson
    {
        public override void Eat()
        {
            //eat pizza
        }

        public override void Sleep()
        {
            //sleep 
        }

        public void Shower()
        {
            //shower
        }
    }
}
