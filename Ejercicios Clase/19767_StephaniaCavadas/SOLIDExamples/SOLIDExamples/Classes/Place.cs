using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDExamples.Classes
{
    public class Place
    {
        public string Name;
        public bool inDanger;
        public int IDPlace;

        public Place(string Name, bool inDanger, int IDPlace)
        {
            this.Name = Name;
            this.inDanger = inDanger;
            this.IDPlace = IDPlace;
        }

    }
}
