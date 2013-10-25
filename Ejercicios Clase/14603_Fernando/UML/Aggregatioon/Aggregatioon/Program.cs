using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aggregatioon
{
    class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address("calle chavakane", 2324);
            Person person = new Person(address);
            Console.WriteLine(person.address.address + " #"+ person.address.number);

            Console.ReadKey();
        }
    }

}
