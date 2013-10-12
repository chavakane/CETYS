using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    /// <summary>
    /// Segregated Shower method in ICleanPerson interface because not 
    /// all derived classes will implement it
    /// </summary>
    public class Person
    {
        public string name;
        public abstract void Eat();
        public abstract void Sleep();
    }
}
