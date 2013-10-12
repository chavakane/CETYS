using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Person
    {
        public string name;

        public virtual string SayName()
        {
            return string.Format("My name is {0}", name);
        }
    }
}
