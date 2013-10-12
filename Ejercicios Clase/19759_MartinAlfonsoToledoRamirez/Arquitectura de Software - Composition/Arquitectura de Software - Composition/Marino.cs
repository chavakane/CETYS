using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arquitectura_de_Software___Composition
{
    class Marino
    {
        public string Nombre { get; set; }
        public tipo_marinero TipoMarinero { get; set; }

        public enum tipo_marinero { Intendencia, Piloto, Mecanico, Capitan };

        /// <summary>
        /// Constructor Marino vacio
        /// </summary>
        public Marino()
        {

        }

        /// <summary>
        /// Constructor Marino con parametros 
        /// </summary>
        /// <param name="nombre">Nombre del marino</param>
        /// <param name="tipomarinero">Tipo de marino que es</param>
        public Marino(string nombre, tipo_marinero tipomarinero)
        {
            Nombre = nombre;
            TipoMarinero = tipomarinero;
        }
    }
}
