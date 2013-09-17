using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadSeptiembre13
{
    class Program
    {
        static void Main(string[] args)
        {
            Pikachu pika = new Pikachu();
            pika.Saludo();
            pika.Attack();

            Pikachu bob = new Pikachu();
            bob.Nombre = "PikaBob";
            bob.Saludo();
            Console.WriteLine(bob.NumeroPokedex.ToString());
            Pokedex.Show();
            Console.ReadKey();
        }
    }
}
