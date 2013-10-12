using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_ClassRelationship
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseballPlayer davidOrtiz = new BaseballPlayer("David Ortiz", new Bat(34), new BattingAvg(40,15));
            Console.WriteLine("The baseball player {0} uses a {1} bat and his batting average is {2}", 
                davidOrtiz.Name, davidOrtiz.bat.size, davidOrtiz.battingAvg.getBattingAvg());
            Console.ReadLine();

            FirstBaseman MarkTexeira = new FirstBaseman("Wilson", "Mark Texeira", new Bat(33), new BattingAvg(50, 12));
            Console.WriteLine("The First Baseman {0} uses a {1} glove, a {2} bat and his batting average is {3}",
                MarkTexeira.Name, MarkTexeira.Glove, MarkTexeira.bat.size, MarkTexeira.battingAvg.getBattingAvg());
            Console.ReadLine();

            Team BostonRedSox = new Team("Boston Red Sox");
            Console.WriteLine(BostonRedSox.joinTeam(davidOrtiz));
            Console.ReadLine();


        }
    }
}
