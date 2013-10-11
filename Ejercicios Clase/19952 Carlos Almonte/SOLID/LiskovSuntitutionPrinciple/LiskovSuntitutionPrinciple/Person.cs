using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSuntitutionPrinciple
{
    abstract class Person
    {
        public string Name { get; set; }
        public string Lastname { get; set; }
        public ushort Age { get; set; }

        public Person(string name, string lastname, ushort age)
        {
            this.Name = name;
            this.Lastname = lastname;
            this.Age = age;
        }

        public abstract string PrintInformation();

    }
}
