using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public static class Calculator
    {
        public static decimal GetSubtotal(Dictionary<string, decimal> products)
        {
            return products.Select(d => d.Value).Sum(); ;
        }

        public static decimal GetTotal(decimal subtotal, decimal tax)
        {
            return subtotal + subtotal * (tax / 100);
        }
    }
}
