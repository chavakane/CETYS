using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generalization
{
    class Parent
    {
        public string Name { get; set; }
        public string Lastname { get; set; }
        public short Age { get; set; }

        public Parent(string name, string lastname, short age)
        {
            this.Name = name;
            this.Lastname = lastname;
            this.Age = age;
        }

        public virtual void Work() { Console.WriteLine(Name + ": Working, cause i'm an adult..."); }

    }
}
