using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arquitectura_de_Software___Aggregation
{
    class Menu
    {
        public string Nombre { get; set; }
        public List<Platillo> Platillos = new List<Platillo>();
        public string Descripcion { get; set; }

        /// <summary>
        /// Constructor Menu vacio
        /// </summary>
        public Menu()
        {
        }

        /// <summary>
        /// Cosntructor Meno con parametros
        /// </summary>
        /// <param name="nombre">Nombre del menu</param>
        /// <param name="descripcion">Descripcion del menu</param>
        public Menu(string nombre, string descripcion)
        {
            Nombre = nombre;
            Descripcion = descripcion;
        }
    }
}
