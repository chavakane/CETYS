using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArquitecturaSoftwarePokemon
{
    public static class ContadorDePokemones
    {
        //state
        public static int contador { get; set; }

        //behavior
        public static void DesplegarTotal()
        {
            Console.WriteLine("Has instanciado " + contador + " Pokemones");
        }
    }
}
