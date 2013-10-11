using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition
{
    class Program
    {
        static Car Vocho;
        
        static void Main(string[] args)
        {
            Vocho = new Car(20, 70.35, "Peña Nieto");

            if (Crash())
                Console.WriteLine("Peña Nieto died!\n");
            else
                Console.WriteLine("Peña Nieto did not died\n");
        }

        private static bool Crash()
        {
            Vocho = null;
            return true;
        }

    }
}
