using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPokemon13Septiembre
{
    class Pikachu : Pokemon
    {
        public Pikachu()
        {
            Nombre = "Pikachu";
        }

        public override int numeroDePokedex
        {
            get { return 25; }
        }

        public override void Ataque()
        {
            Console.WriteLine(Nombre + " utiliza impactrueno!");
        }

    }
}
