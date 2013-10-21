using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLClassDiagramRelationshipsJorgeDiaz
{
    //Parte Aggregation, un departamento puede tener empleados pero puede existir sin ellos (el constructor no necesito empleados)

    class Departamento
    {
        public string nombreDeDepartamento;
        public int numeroDeEdificio;
        private List<Empleado> empleados = new List<Empleado>();

        public Departamento(string NombreDeDepartamento, int NumeroDeEdificio)
        {
            numeroDeEdificio = NumeroDeEdificio;
            nombreDeDepartamento = NombreDeDepartamento;
        }

        public void agregarEmpleado()
        {
            //agregar empleado aqui.
        }
    }
}
