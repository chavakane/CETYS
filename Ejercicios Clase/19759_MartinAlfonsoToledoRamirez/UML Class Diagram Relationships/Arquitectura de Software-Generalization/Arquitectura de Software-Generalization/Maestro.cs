using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arquitectura_de_Software_Generalization
{
    class Maestro:Persona
    {
        public string ClaveMaestro { get; set; }

        /// <summary>
        /// Constructor Maestro vacio
        /// </summary>
        public Maestro()
        {
        }

        /// <summary>
        /// Constructor Maestro con parametros
        /// </summary>
        /// <param name="nombre">Nombre del Maestro</param>
        /// <param name="clavemaestro">Clave del maestro</param>
        public Maestro(string nombre, string clavemaestro)
        {
            Nombre = nombre;
            ClaveMaestro = clavemaestro;
        }

    }
}
