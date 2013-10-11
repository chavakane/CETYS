using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public static class Printer
    {
        public static void PrintDocument(Document document)
        {
            Console.WriteLine(document.toString());
        }
    }
}
