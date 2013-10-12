using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_ClassRelationship
{
    class BaseballPlayer
    {
        public string Name { get; set; }
        public Bat bat { get; set; }
        public BattingAvg battingAvg { get; set; }

        public BaseballPlayer(string n, Bat b, BattingAvg ba)
        {
            Name = n;
            bat = b;
            battingAvg = ba;
        }
    }
}
