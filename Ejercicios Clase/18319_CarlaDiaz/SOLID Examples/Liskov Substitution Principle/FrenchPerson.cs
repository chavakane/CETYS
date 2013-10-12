using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class FrenchPerson : Person
    {
        public string SayNameInFrench()
        {
            return string.Format("Mon nom est {0}", name);
        }
    }
}
