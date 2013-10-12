using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagramRelationships
{
    class Asociacion
    {
        
        public class Universidad: Estudiante
        {
            Estudiante Estudiante;
            string Carrera;         
        }

        public class Estudiante
        {
            string Nombre;     
        }
    
       
        

    }
}
