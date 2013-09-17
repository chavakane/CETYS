using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadSeptiembre13
{
    public static class Pokedex
    {
        public static int Contador { get; set; }

        public static void Show()
        {
            Console.WriteLine("Has instanciado "+Contador+" pokemons");
        }
    }
}
