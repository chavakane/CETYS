using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    public class Rectangle
    {
        public int Height { get; set; }
        public int Width { get; set; }

        public int Area()
        {
            return Height * Width;
        }

    }
    public class DrawRectangle
    {
        public void Draw(Rectangle rectangle)
        {
            Console.WriteLine("I'm drawing a rectangle");
        }
    }
}
