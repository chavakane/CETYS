using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class TacoShop
    {
        string address;
        Person owner;

        public string Address {
            get { return address; }            
        }

        public Person Owner {
            get { return owner; }
            set { owner = value; }
        }

        public TacoShop(string address, Person owner)
        {
            this.address = address;
            this.owner = owner;
        }
    }
}
