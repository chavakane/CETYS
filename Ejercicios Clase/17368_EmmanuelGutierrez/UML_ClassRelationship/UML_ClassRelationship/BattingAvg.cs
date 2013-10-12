using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_ClassRelationship
{
    class BattingAvg
    {
        public double atBats { get; set; }
        public double hits { get; set; }

        public BattingAvg(double ab, double h)
        {
            atBats = ab;
            hits = h;
        }

        public double getBattingAvg()
        {
            return hits / atBats;
        }
    }
}
