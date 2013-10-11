using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association
{
    class Person
    {
        public string Name { get; set; }
        public string Lastname { get; set; }
        public uint ID { get; set; }
        public List<Account> Accounts { get; set; }

        public Person(string name, string lastname, uint id, Account firstaccount)
        {
            this.Accounts = new List<Account>();
            this.Name = name;
            this.Lastname = lastname;
            this.ID = id;
            this.Accounts.Add(firstaccount);
        }

    }
}
