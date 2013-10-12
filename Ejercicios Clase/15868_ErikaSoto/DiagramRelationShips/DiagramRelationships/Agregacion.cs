using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagramRelationships
{
    class Agregacion
    {
        
        public class Compania
        {
            int numEmpleado;
            Persona empleados;

            void ContratarEmpleado(Persona persona)
            {
                this.empleados = persona;
            }
        }

        public class Persona
        {
            string Nombre;
        }

    }
}
