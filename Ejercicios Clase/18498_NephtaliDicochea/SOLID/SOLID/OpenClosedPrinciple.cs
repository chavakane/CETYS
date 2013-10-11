using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public class HorsePowerCalculator
    {
        IEnumerable<ICar> _cars;
        public HorsePowerCalculator(IEnumerable<ICar> cars) { this._cars = cars; }

        public void CalculateHorsePowerCalculator()
        {
            CarController controller = new CarController();
            foreach (var car in _cars)
            {
                Console.WriteLine("HP of the car {0} is {1}", car.Name, controller.GetCarHP(car.Name));
            }
        }
    }

    public class CarController
    {
        List<ICar> cars;
        public CarController()
        {
            cars = new List<ICar>();
            cars.Add(new Honda());
            cars.Add(new Toyota());
        }

        public string GetCarHP(string name)
        {
            return cars.First(car => car.Name == name).GetHP();
        }
    }

    public interface ICar
    {
        string Name { get; set; }
        string GetHP();
    }

    public class Honda : ICar
    {
        public string Name { get; set; }

        public string GetHP()
        {
            return "10HP";
        }
    }

    public class Toyota : ICar
    {
        public string Name { get; set; }

        public string GetHP()
        {
            return "20HP";
        }
    }
}
