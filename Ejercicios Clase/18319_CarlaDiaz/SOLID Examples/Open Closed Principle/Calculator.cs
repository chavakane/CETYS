using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    /// <summary>
    /// Closed for modification, calculator will always calculate
    /// </summary>
    public abstract class Calculator
    {
        public abstract double Calculate(params double[] nums);
    }
}
