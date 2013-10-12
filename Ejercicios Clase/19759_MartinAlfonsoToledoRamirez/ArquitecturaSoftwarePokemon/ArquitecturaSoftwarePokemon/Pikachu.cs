using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArquitecturaSoftwarePokemon
{
    class Pikachu:Pokemon
    {
        public Pikachu()
        {
            Nombre = "Pikachu";
        }

        public override int NumeroPokedex
        {
            get { return 25; }
        }

        public override void Saluda()
        {
            //Si se quiere hacer el metodo que se hace en la clase padre se utiliza la siguiente linea comentada
            //base.Saluda();
            Console.WriteLine(Nombre + ": Pika Pika :D");
        }
        public override void Ataca()
        {
            Console.WriteLine(Nombre + ": Impact Trueno!!!!! --> Pika...Pika...Chuuuuuuuuuuuuuuu!!!");
        }

    }
}
