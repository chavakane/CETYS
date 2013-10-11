using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSuntitutionPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker worker1 = new Worker("Carlos", "Almonte", 22, "Bajaware");
            CouchPotato couchpotato1 = new CouchPotato("Bob", "X", 43, 14);

            Person[] persons = new Person[2] { worker1, couchpotato1 };

            foreach (Person p in persons)
                Console.WriteLine(p.PrintInformation());

            persons[1] = new Worker("Oscar", "Rosas", 21, "Bajaware");

            foreach (Person p in persons)
                Console.WriteLine(p.PrintInformation());

        }

    }
}
