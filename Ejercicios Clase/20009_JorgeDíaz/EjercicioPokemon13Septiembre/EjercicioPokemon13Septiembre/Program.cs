using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPokemon13Septiembre
{
    class Program
    {
        static void Main(string[] args)
        {
            Pikachu pikachuDeAsh = new Pikachu();
            pikachuDeAsh.Nombre = "Pikachu de Ash";
            pikachuDeAsh.Saludo();

            Snorlax snorlax = new Snorlax()
            {
                Nombre = "Dormilon",
                peso = 1000
            };
            snorlax.Saludo();

            ContadorDePokemon.DesplegarTotal();
            Console.ReadLine();
        }
    }
}
