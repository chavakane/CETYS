using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPokemon13Septiembre
{
    class ContadorDePokemon
    {

        public static int contador { get; set; }

        public static void DesplegarTotal()
        {
            Console.WriteLine("Has capturado " + contador + " pokemons");
        }
    }
}
