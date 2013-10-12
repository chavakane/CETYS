using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagramRelationships
{
    class Generalizacion
    {
        public class Persona
        {
            string Nombre;
        }
        public class Empleado : Persona
        {
            decimal sueldo;
        }
    
    }
}
