using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency
{
    static class Printer
    {
        public static void Print(Document document)
        {
            Console.WriteLine("I'm printing, yo");
            Console.WriteLine("-------------------------------");
            Console.WriteLine(document.filename);
            Console.WriteLine(document.text);
            Console.WriteLine("-------------------------------");
            Console.WriteLine("I'm finished, yo");
        }
    }
}
