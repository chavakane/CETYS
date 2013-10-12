using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    /// <summary>
    /// Barista is only responsible for preparing coffee
    /// </summary>
    public class Barista : StarbucksEmployee
    {
        public Coffee PrepareCoffee()
        {
            return new Coffee();
        }
    }
}
