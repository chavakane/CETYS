using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    class InterfaceSegregationPrinciple
    {
        public interface IRightHanded
        {
            void MoveRightHand();
        }

        public interface ILeftHanded
        {
            void MoveLeftHand();
        }

        public class LeftHandedPerson : ILeftHanded
        {
            public void MoveLeftHand()
            {
                //Move left hand :3
            }
        }

        public class AmbidextrousPerson : ILeftHanded, IRightHanded
        {
            public void MoveLeftHand()
            {
                //Move left hand :3
            }

            public void MoveRightHand()
            {
                //Move right hand :3
            }
        }
    }
}
