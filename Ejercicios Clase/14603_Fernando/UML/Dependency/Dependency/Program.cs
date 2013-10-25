using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency
{
    class Program
    {
        static void Main(string[] args)
        {
            Document doc = new Document("helloworld.txt", "Hello, man");
            Printer.Print(doc);
            Console.ReadKey();
        }
    }
}
