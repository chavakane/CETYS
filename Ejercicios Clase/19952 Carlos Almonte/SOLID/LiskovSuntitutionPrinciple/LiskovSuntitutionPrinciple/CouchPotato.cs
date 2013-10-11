using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSuntitutionPrinciple
{
    class CouchPotato : Person
    {
        public ulong HoursWatchingTV { get; set; }

        public CouchPotato(string name, string lastname, ushort age, ulong hours)
            : base(name, lastname, age)
        {
            this.HoursWatchingTV = hours;
        }

        public override string PrintInformation()
        {
            return "Name: " + base.Name + "\nLastname: " + base.Lastname + "\nAge: " + base.Age.ToString() + "\nHours watching TV: " + this.HoursWatchingTV.ToString();
        }

    }
}
