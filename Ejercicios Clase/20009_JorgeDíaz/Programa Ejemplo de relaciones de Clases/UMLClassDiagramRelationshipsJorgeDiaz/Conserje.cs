using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLClassDiagramRelationshipsJorgeDiaz
{
    //Generalizacion, conserje es un empleado.

    class Conserje : Empleado
    {
        public int numeroDeEdificio;

        public Conserje()
        {
            nombres = "Conseje grande y poderoso";
        }

        public void LimpiarPiso()
        { 
        // Limpiar piso aqui.
        }
    }
}
