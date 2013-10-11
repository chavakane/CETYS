using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition
{
    class Car
    {

        public double gas { get; set; }
        public double speed { get; set; }
        public double maxspeed { get; set; }
        public Driver Driver { get; set; }

        public Car(double gas, double max, string driver)
        {
            this.gas = gas;
            this.maxspeed = max;
            this.speed = 0;
            this.Driver = new RegularDriver(driver);
        }
    }
}
