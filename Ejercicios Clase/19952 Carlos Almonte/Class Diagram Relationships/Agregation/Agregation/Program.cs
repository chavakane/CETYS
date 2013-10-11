using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agregation
{
    class Program
    {

        static Car minicooper;
        static Transporter transporter;

        static void Main(string[] args)
        {
            transporter = new Transporter("The Transporter");
            minicooper = new Car(30.5, 250, transporter);
            if (Crash())
                Console.WriteLine(transporter.Name + " died\n");
            else
                Console.WriteLine(transporter.Name + " did not died!\n");
        }

        private static bool Crash()
        {
            minicooper = null;
            if (transporter != null)
                return false;
            else
                return true;
        }

    }
}
