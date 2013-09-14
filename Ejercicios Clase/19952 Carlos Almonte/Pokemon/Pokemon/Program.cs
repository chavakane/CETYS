using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            Pikachu pikachu = new Pikachu();
            pikachu.Saludo();
            
            Snorlax dormilon = new Snorlax();
            dormilon.Saludo();

            ContadorDePolemons.DesplegarTotal();
        }
    }
}
