using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadSeptiembre13
{
    public abstract class Pokemon
    {
        public Pokemon()
        {
            Pokedex.Contador++;
        }
        //State
        private string nombre;

        public string Nombre 
        {
            get { return nombre; }
            set 
            { 
                nombre = value;
                nombre = nombre.ToLowerInvariant();
            }
        }
        public string Tipo { get; set; }
        public string Genero { get; set; }
        public abstract int NumeroPokedex { get; }
        public float Peso { get; set; }
        public float Estatura { get; set; }

        //Behavior
        public abstract void Attack();
        public virtual void Saludo()
        {
            Console.WriteLine(Nombre+": ");
        }
    }
}
