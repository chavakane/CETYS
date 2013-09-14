using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    abstract class Pokemon
    {
        public Pokemon()
        {
            ContadorDePolemons.Contador++;
        }

        //Status
        public abstract int NumeroDePokedex { get; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public string Genero { get; set; }
        public float Peso { get; set; }
        public float Estatura { get; set; }

        //Behavior
        public abstract void Ataque();

        public virtual void Saludo()
        {
            Console.Write(Nombre + " dice: ");
        }

    }
}
