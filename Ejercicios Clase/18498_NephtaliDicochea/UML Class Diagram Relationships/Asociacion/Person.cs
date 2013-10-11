using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Person
    {
        string name;
        DateTime birthday;
        string email;

        public string Name { 
            get { return name; }
        }

        public DateTime Birthday { 
            get { return birthday; }
        }

        public string Email {
            get { return email; }
            set { email = value; }
        }

        public Person(string name, DateTime birthday, string email)
        {
            this.name = name;
            this.birthday = birthday;
            this.email = email;
        }
    }
}
