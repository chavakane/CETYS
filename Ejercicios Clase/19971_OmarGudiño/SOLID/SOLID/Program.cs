using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            // Single Responsability : Cada integrante toca el instrumento que se le asigna aunque pueda tocar otros si es necesario
            // Open Closed Princial  : Cuando se pide que toquen un instrumento, se hace "play" pero dependiendo de la clase es lo que hara "play"
            // Liskov Substitution Principle : Esta implementado para que un cambio en el Musician Singer no afecte al Musician Drummer
            // Interface Segregation Principle : Trabajos separados por diferentes Interfaces para que hagan solamente su trabajo y sean flexibles
            // Dependency Inversion Principle  : Cada Musician depende solamente de la interfaz IMusician y solo la necesitan para su comportamiento.
            
            Band rockBand = new Band();
            ICrew crew = new Roadie();
            Singer singer = new Singer();
            Bassist bassist = new Bassist();
            Drummer drummer = new Drummer();
            Guitarist guitarrist = new Guitarist();

            rockBand.playInstrument(drummer);
            crew.Travel();

            Console.ReadLine();
        }
    }
}
