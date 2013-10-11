using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciples
{
    class Program
    {
        static void Main(string[] args)
        {
            SortingSystem bubble = new SortingSystem();
            FasterSortSystem selection = new FasterSortSystem();
            int[] numbers = new int[10] { 2, 43, 12, 21, 6, 11, 10, 9, 17, 1 };

            //lowest to highest
            int[] sorted = bubble.Sort(numbers);
            foreach (int i in sorted)
                Console.WriteLine(i.ToString());

            Console.WriteLine("");

            //highest to lowest
            sorted = selection.Sort(numbers);
            foreach (int i in sorted)
                Console.WriteLine(i.ToString());

        }
    }
}
