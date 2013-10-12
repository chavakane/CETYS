using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arquitectura_de_Software_Generalization
{
    class Alumno:Persona
    {
        public int Matricula { get; set; }


        public Alumno()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nombre">Nombre del Alumno</param>
        /// <param name="matricula">Matricula del Alumno</param>
        public Alumno(string nombre, int matricula)
        {
            Nombre = nombre;
            Matricula = matricula;
        }
    }
}
