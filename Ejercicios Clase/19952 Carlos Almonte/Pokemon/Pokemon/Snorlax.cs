using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    class Snorlax : Pokemon
    {
        public Snorlax()
        {
            base.Nombre = "Snorlax";
        }

        public override int NumeroDePokedex
        {
            get { return 143; }
        }

        public override void Ataque()
        {
            Console.WriteLine("ZzZzZzZzZz");
        }

        public override void Saludo()
        {
            base.Saludo();
            Console.WriteLine("Hola que hace");
        }
        
    }
}
