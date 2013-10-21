using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLClassDiagramRelationshipsJorgeDiaz
{

    //Parte de Generalizacion
    public class Empleado
    {
        List<Horario> horarios = new List<Horario>();
        public int ID { get; set; }
        private string Nombres;
        public string nombres
        {
            get
            {
                return Nombres;
            }
            set
            {
                Nombres = value;
            }
        }
        public string apellidos { get; set; }

        public void ImprimirInfo()
        {
            Console.WriteLine(Nombres);
        }

        //Dependencia, un empleado necesita un producto para trabajar <<create dependency>> 
        public Producto producto = new Producto();

        //Composicion
        public void AgregarHorario(string turno, int horasQueTrabaja)
        {
            horarios.Add(new Horario(turno, horasQueTrabaja, this));
        }

        //Asociacion
        public void SolicitarPago()
        { 
        //Condicional aqui para que el sistema pague
            SistemaDeCheques.pagarAEmpleado();
        }

        

    }
}
