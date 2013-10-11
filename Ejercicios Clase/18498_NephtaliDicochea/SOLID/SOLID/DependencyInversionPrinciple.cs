using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    class DependencyInversionPrinciple
    {
        interface IMotor
        {
            void Accelerate();
        }

        class Car : IMotor
        {
            public void Accelerate()
            {
                //Accelerate
            }
        }

        class SuperCar : IMotor
        {
            public void Accelerate()
            {
                //Accelerate more
            }
        }

        class Driver
        {
            public ICar MyCar { get; set; }

            public Driver(ICar myCar)
            {
                MyCar = myCar;
            }
        }
    }
}
