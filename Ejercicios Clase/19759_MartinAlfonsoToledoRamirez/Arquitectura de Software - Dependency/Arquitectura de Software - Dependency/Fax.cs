using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arquitectura_de_Software___Dependency
{
    class Fax
    {
        public string Nombre {get; set;}

        /// <summary>
        /// Constructor Fax vacio
        /// </summary>
        public Fax()
        {

        }

        /// <summary>
        /// Constructor Fax con parametros
        /// </summary>
        /// <param name="nombre">Nombre del Fax</param>
        public Fax(string nombre)
        {
            Nombre = nombre;
        }

        public string imprimir(Documento documento)
        {
            string texto = documento.ObtenetMensaje();
            return texto;
        }
    }

}
