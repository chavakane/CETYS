using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generalization
{
    class Program
    {
        static void Main(string[] args)
        {
            Parent[] family = new Parent[2];
            family[0] = new Parent("Carlos", "Almonte", 40);
            family[1] = new Child("Carlitos", "Almonte", 15, 25);

            foreach (Parent member in family)
                member.Work();
        }
    }
}
