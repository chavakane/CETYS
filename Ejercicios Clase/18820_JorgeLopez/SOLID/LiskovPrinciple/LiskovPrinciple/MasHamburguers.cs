using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovPrinciple
{
    /*El que mas me ha costado entender, de lo que puedo rescatar lo siguiente:
     Si bien al heredar clases procurarmos no repetirnos, el andar de simple puede
     traernos algunas desventajas y terminar como en este ejercicio. No queremos repetir
     el metodo imprimir Ingredientes pero tampoco queremos que el programa sea susceptible 
     a errores de logica y luego nos quieran dar una famous a cambio de una teriyaki
     porque ps' son hamburguesas de todos modos.*/
    
    class DoubleWesternBacon
    {
        public void AgregarCarne() { }
        public void AgregarLechuga() { }
        public void AgregarPan() { }
        public void AgregarTocino() { }
        public string ObtenerNombre() 
        {
            //Regresa todos los ingredientes involucrados
            //return ingredientes[];
            //for simplicity y para que VS no diga error
            return "Tocino";
        }
    }
    class Teriyaki : DoubleWesternBacon 
    {
        public void AgregarPigna() 
        {
            //agrega pigna a ingredientes[]
        } 
    }

    class Cocina
    {
        private static DoubleWesternBacon w;
        public static DoubleWesternBacon CrearDoubleWesternBacon()
        {
            w = new Teriyaki();
            return w;
        }
        public string EntregarPedido()
        {
            //aqui tendremos una western muy peculiar
            //porque aparecera que tiene pigna
            return w.ObtenerNombre();
        }
    }
}
