using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arquitectura_de_Software___Association
{
    class Chef
    {
        public string Nombre { get; set; }
        /// <summary>
        /// Constructor Chef vacio
        /// </summary>
        public Chef()
        {

        }

        /// <summary>
        /// Constructor de Chef con parametros
        /// </summary>
        /// <param name="nombre">Nombre del Chef</param>
        public Chef(string nombre)
        {
            Nombre = nombre;
        }
    }
}
