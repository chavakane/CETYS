using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    /// <summary>
    /// Extending base class
    /// </summary>
    public class SumCalculator : Calculator
    {
        public override double Calculate(params double[] nums)
        {
            return nums.Sum();
        }
    }
}
