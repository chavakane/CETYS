using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagramRelationships
{
    class Dependencia
    {
        public class SuperMercado
        {
            string articulos;
            int precio;

            public Proveedores Crear()
            { 
                return new Proveedores();
            }
        }

        public class Proveedores
        {
            string articulos;
            int precio; 
        }
    
    }
}
