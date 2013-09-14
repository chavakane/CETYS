using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArquitecturaSoftwarePokemon
{
    class Snorlax : Pokemon
    {
        public Snorlax()
        {
            Nombre = "Pikachu";
        }

        public override int NumeroPokedex
        {
            get { return 143; }
        }

        public override void Ataca()
        {
            Console.WriteLine(Nombre + ": Headbutt!!! --> Snooooor!!!");
        }

        public override void Saluda()
        {
            //base.Saluda();
            Console.WriteLine(Nombre + ": Snorlax Snorlax :D");
        }

        public void Dormir()
        {
            //base.Saluda();
            Console.WriteLine(Nombre + ": ZZZzzzZZZzzzZZZ");
        }
    }
}
