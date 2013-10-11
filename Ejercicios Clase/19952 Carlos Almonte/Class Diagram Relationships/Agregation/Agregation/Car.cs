using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agregation
{
    class Car
    {

        public double gas { get; set; }
        public double speed { get; set; }
        public double maxspeed { get; set; }
        public Driver Driver { get; set; }

        public Car(double gas, double max, Driver driver)
        {
            this.gas = gas;
            this.maxspeed = max;
            this.speed = 0;
            this.Driver = driver;
        }
    }
}
