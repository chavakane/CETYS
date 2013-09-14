using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArquitecturaSoftwarePokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            Pikachu Pikachu1 = new Pikachu();
            Pikachu1.Nombre = "Oliver";
            //Pikachu1.Ataca();
            Pikachu1.Saluda();
            Console.WriteLine(Pikachu1.NumeroPokedex);
            ContadorDePokemones.DesplegarTotal();
            Snorlax Snorlax1 = new Snorlax()
                {
                    Nombre = "Mikey",
                    Peso = 200
                };
            Snorlax1.Saluda();
            Snorlax1.Ataca();
            Snorlax1.Dormir();
            ContadorDePokemones.DesplegarTotal();
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ReadLine();

        }
    }
}
