using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_ClassRelationship
{
    class FirstBaseman:BaseballPlayer
    {
        public string Glove { get; set; }

        public FirstBaseman(string g, string n, Bat b, BattingAvg ba): base(n,b,ba)
        {
            Glove = g;
            Name = n;
            bat = b;
            battingAvg = ba;
        }
    }
}
