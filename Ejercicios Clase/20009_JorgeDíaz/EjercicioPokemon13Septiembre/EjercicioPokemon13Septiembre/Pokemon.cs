using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPokemon13Septiembre
{
   abstract class Pokemon
    {
        public Pokemon()
        {
            ContadorDePokemon.contador++;
        }

        private string nombre;
        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }

            public abstract int numeroDePokedex { get; }
            public float peso {get; set;}
            public float  estatura {get; set;}
            public string tipo { get; set; }
            public string genero { get; set; }

            public abstract void Ataque();
            public virtual void Saludo()
            {
                Console.WriteLine(nombre + "te saluda y luego se vuelve un ninja y desaparece");
            }



    }
}
