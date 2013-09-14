using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArquitecturaSoftwarePokemon
{
    public abstract class Pokemon
    {


        public Pokemon()
        {
            ContadorDePokemones.contador++;
        }

        //state
        //public int vida { get; set; }
        //public  int nivel { get; set; }
        public string Tipo { get; set; }
        public string Genero { get; set; }
        public abstract int NumeroPokedex {get;}
        public float Estatura { get; set; }
        public float Peso { get; set; }

        //public string Nombre { get; set; }
        private string _Nombre;
        public string Nombre
        {
            get
            {
                return _Nombre;
            }
            set
            {
                _Nombre = value;
            }
        }


        //behavior
        public abstract void Ataca();
        public virtual void Saluda()
        {
            Console.WriteLine(Nombre + ": ");
        }


    }
}
