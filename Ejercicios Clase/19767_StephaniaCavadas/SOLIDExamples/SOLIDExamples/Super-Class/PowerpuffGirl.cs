using SOLIDExamples.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDExamples
{
    public class PowerpuffGirl
    {
        public string Name;
        public Enemy Enemy;

        public void SuperhumanPowers(string power)
        {
            switch (power.ToLower())
            {
                case "flight":
                    Console.WriteLine("{0}: Flighting ^_^",this.Name);
                    break;

                case "heat vision":
                    Console.WriteLine("{0}: Using heat vision!!!",this.Name);
                    break;

                case "night vision":
                    Console.WriteLine("{0}: Using night vision!!!",this.Name);
                    break;

                case "energy protection":
                    Console.WriteLine("{0}: I will use my enery protection!!",this.Name);
                    break;
            }
        }


    }

}