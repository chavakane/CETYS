using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public class CarWash
    {
        ICarWashDoorsStuff _gateUtility;

        public CarWash(ICarWashDoorsStuff gateUtility)
        {
            this._gateUtility = gateUtility;
        }
        public void OpenForService()
        {
            _gateUtility.OpenGate();
        }

        public void DoWash()
        {
            //Wash a car
        }

        public void CloseForDay()
        {
            _gateUtility.CloseGate();
        }
    }

    public class CarWashDoors : ICarWashDoorsStuff
    {
        public void OpenGate()
        {
            //Open the shop if the time is later than 9 AM
        }

        public void CloseGate()
        {
            //Close the shop if the time has crossed 6PM
        }
    }

    public interface ICarWashDoorsStuff
    {
        void OpenGate();
        void CloseGate();
    }
}
