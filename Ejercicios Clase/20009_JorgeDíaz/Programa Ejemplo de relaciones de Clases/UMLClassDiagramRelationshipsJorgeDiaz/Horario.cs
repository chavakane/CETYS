using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLClassDiagramRelationshipsJorgeDiaz
{
    //Componente de empleado

    class Horario
    {
       private string turno;
       private int horasQueTrabaja;
       private Empleado empleado;

        public Horario(string Turno, int HorasQueTrabaja, Empleado Empleado)
        {
            turno = Turno;
            horasQueTrabaja = HorasQueTrabaja;
            empleado = Empleado;
        }
    }
}
