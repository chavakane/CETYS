using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    static class ContadorDePolemons
    {
        public static int Contador { get; set; }
        
        //Behavior
        public static void DesplegarTotal()
        {
            Console.WriteLine("Total = " + Contador.ToString());
        }
    }
}
