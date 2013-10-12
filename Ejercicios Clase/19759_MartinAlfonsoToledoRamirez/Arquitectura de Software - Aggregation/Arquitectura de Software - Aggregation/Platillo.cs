using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arquitectura_de_Software___Aggregation
{
    class Platillo
    {
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public string Descripcion { get; set; }

        /// <summary>
        /// Constructor Platillo vacio
        /// </summary>
        public Platillo()
        {

        }

        /// <summary>
        /// Constructor Platillo con parametros
        /// </summary>
        /// <param name="nombre">Nombre del platillo</param>
        /// <param name="precio">Precio del platillo</param>
        /// <param name="descripcion">Descripcion del platillo</param>
        public Platillo(string nombre, double precio, string descripcion)
        {
            Nombre = nombre;
            Precio = precio;
            Descripcion = descripcion;
        }
    }
}
