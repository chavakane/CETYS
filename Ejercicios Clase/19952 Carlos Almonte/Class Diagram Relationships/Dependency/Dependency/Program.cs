using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency
{
    class Program
    {
        static void Main(string[] args)
        {
            Client oxxo = new Client("OXXO", 250000);
            Suplier sabritas = new Suplier("Sabritas", 1000000, oxxo);

            Console.WriteLine(oxxo.Naae + " has: " + oxxo.PrintBudget);
            Console.WriteLine(sabritas.Name + " has: " + sabritas.TotalBudget.ToString());
            oxxo.Spend();
            Console.WriteLine(oxxo.Naae + " has: " + oxxo.PrintBudget);
            Console.WriteLine(sabritas.Name + " has: " + sabritas.TotalBudget.ToString());
        }
    }
}
