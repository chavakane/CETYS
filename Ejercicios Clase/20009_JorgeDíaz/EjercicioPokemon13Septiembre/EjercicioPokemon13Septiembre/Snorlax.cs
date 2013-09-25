using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPokemon13Septiembre
{
    class Snorlax : Pokemon
    {
        public Snorlax()
        {
            Nombre = "Snorlax";
        }

        public override int numeroDePokedex
        {
            get { return 143; }
        }

        public void Dormir()
        {
            Console.WriteLine(Nombre + " se fue a dormir, 'zzzzzz'");
        }
        public override void Saludo()
        {
            base.Saludo();
        }
        public override void Ataque()
        {
            Console.WriteLine(Nombre + " utiliza tackleada");
        }

    }
}
