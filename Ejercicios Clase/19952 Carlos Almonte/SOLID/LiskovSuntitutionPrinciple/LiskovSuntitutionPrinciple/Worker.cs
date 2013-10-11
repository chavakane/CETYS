using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSuntitutionPrinciple
{
    class Worker : Person
    {
        string Company { get; set; }

        public Worker(string name, string lastname, ushort age, string company)
            : base(name, lastname, age)
        {
            this.Company = company;
        }

        public override string PrintInformation()
        {
            return "Name: " + base.Name + "\nLastname: " + base.Lastname + "\nAge: " + base.Age.ToString() + "\nCompany: " + this.Company;
        }

    }
}
