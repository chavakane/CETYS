using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    /// <summary>
    /// Extending base class
    /// </summary>
    public class MultCalculator : Calculator
    {
        public override double Calculate(params double[] nums)
        {
            return nums.Aggregate(1.0, (a, b) => a*b);
        }
    }
}
