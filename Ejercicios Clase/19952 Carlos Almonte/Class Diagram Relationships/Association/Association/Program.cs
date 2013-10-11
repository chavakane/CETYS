using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association
{
    class Program
    {
        static void Main(string[] args)
        {
            Account a1 = new Account(19952, @"email1@email.com");
            Person carlos = new Person("Carlos", "Almonte", 19952, a1);
            Account a2 = new Account(carlos.ID, @"email2@email.com");
            carlos.Accounts.Add(a2);

            foreach (Account a in carlos.Accounts)
                Console.WriteLine("ID: " + a.ID + "\nE-mail: " + a.Email);
        }
    }
}
