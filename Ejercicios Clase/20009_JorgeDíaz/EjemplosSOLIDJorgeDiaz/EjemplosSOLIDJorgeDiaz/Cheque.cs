using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemplosSOLIDJorgeDiaz
{

    //En esta documento se encuentra el Open-Closed principle. Si se quiere calcular el pago no se tiene que modificar
    // una clase, solo see ocupa agregar una nueva que implemente el metodo a su manera usando abstraccion.

    //Tambien se encuentra el Liskov Substitution principle presente. Que se podria tomar
    // como una extension del principio open-close.Liskov substitution se cumple cuando
    // las clases derivadas de una clase base extienden la funcionalidad de la clase base
    // sin cambiar su comportamiento de alguna manera.

    public abstract class FormaDePago
    {
        public abstract double calcularPago(int a);

    }

    class Cheque : FormaDePago
    {
        private string nombre;
        private string banco;
        private int IDDeCheque;

        public override double calcularPago(int numeroDeCheque)
        {
            // Calcula el dinero se puede pagar en base al cheque
            return 0;
        }
      
    }

    class TarjetaDeCredito : FormaDePago
    {
        private string nombre;
        protected int numeroDeTarjeta;

        public override double calcularPago(int numeroDeTarjetaDeCredito)
        {
            // Calcular pago segun datos de la tarjeta
            return 0;
        }
    }
}
