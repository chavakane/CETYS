using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple
{
    /*En esta empresa totalmente ficticia, el manager sele regalarles hamburguesas a los empleados
     Pero no todos atienden la parrilla ni todos cobran a clientes. si bien logramos reunir a todos 
     los trabajadores en una interfaz para poder manejarlos mejor, se ha vuelto complicado tener
     todos los comportamientos en la misma interfaz. Preferible tener mas de una interfaz que ayuden
     a aligerar la carga de la SUPERINTERFACE, y sea mas entendible el codigo.*/
    interface IWorkityWork
    {
        public void AtenderParrilla() { }
        public void CobrarClientes() { }
        public void ComerHamburguesaGratisDelDia() { }
    }

    class Parrillero : IWorkityWork
    {
        public void AtenderParrilla() { }
        public void CobrarClientes() { }
        public void ComerHamburguesaGratisDelDia() { }
    }
    class Cajera : IWorkityWork
    {
        public void AtenderParrilla() { }
        public void CobrarClientes() { }
        public void ComerHamburguesaGratisDelDia() { }
    }
    class Manager
    {
        public void AgarrarUnMono(IWorkityWork w) { }
        public void PnerloATrabajar() { }
    }

}
