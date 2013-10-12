using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arquitectura_de_Software___Composition
{
    class Embarcacion
    {
        public string Nombre { get; set; }
        public Marino Capitan = new Marino();
        public List<Marino> Marinos = new List<Marino>();

        /// <summary>
        /// Constructor Embarcacion vacio
        /// </summary>
        public Embarcacion()
        {
            Capitan.TipoMarinero = Marino.tipo_marinero.Capitan;
        }

        /// <summary>
        /// Constructor Embarcacion con parametros
        /// </summary>
        /// <param name="nombreembarcacion">Nombre de la Embarcacion</param>
        /// <param name="nombrecapitan">Nombre del Capitan</param>
        public Embarcacion(string nombreembarcacion, string nombrecapitan)
        {
            Nombre = nombreembarcacion;
            Capitan.Nombre = nombrecapitan;
            Capitan.TipoMarinero = Marino.tipo_marinero.Capitan;
        }
    }
}
