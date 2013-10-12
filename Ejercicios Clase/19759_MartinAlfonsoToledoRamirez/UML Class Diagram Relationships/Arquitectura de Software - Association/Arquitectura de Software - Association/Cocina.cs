using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arquitectura_de_Software___Association
{
    class Cocina
    {
        public Chef Cocinero { get; set; }
        public string Nombre { get; set; }
        public string Estilo { get; set; }
        /// <summary>
        /// Constructor Cocina vacio
        /// </summary>
        public Cocina()
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cocinero">Chef de esta cocina</param>
        /// <param name="nombre">Nombre de la cocina</param>
        /// <param name="estilo">Estilo de la cocina</param>
        public Cocina(Chef cocinero, string nombre, string estilo)
        {
            Cocinero = cocinero;
            Nombre = nombre;
            Estilo = estilo;
        }
    }
}
