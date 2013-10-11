using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsabilityPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            double Base = 10.5, Height = 14.6;
            double Area = TriangleArea(Base, Height);
            Console.WriteLine("Base: " + Base.ToString() + "\nHeight: " + Height.ToString() + "\n\nArea: " + Area.ToString());
        }

        public static double TriangleArea(double b, double h)
        {
            double result = Multiply.Multiplication(b, h);
            result = Divide.Division(result, 2);
            return result;
        }

    }
}
