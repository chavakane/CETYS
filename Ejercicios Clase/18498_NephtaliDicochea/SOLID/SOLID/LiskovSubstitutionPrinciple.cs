using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    class LiskovSubstitutionPrinciple
    {
        public abstract class Vegetable
        {
            public abstract string GetColor();
        }

        public class Tomatoe : Vegetable
        {
            public override string GetColor()
            {
                return "Red";
            }
        }

        public class Celery : Vegetable
        {
            public override string GetColor()
            {
                return "Green";
            }
        }
    }
}
