using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arquitectura_de_Software___Dependency
{
    class Documento
    {
        public string Mensaje { get; set; }


        /// <summary>
        /// Constructor Documento vacio
        /// </summary>
        public Documento()
        {

        }

        /// <summary>
        /// Constructor Documento con parametros
        /// </summary>
        /// <param name="mensaje">Mensaje del documento</param>
        public Documento(string mensaje)
        {
            Mensaje = mensaje;
        }

        public string ObtenetMensaje()
        {
            return Mensaje;
        }
    }
}
