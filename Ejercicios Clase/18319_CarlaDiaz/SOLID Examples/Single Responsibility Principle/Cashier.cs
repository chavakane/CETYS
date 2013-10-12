using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    /// <summary>
    /// Cashier is only responsible for taking the customers' order 
    /// </summary>
    public class Cashier : StarbucksEmployee
    {
        public decimal TakeOrder(List<Coffee> order)
        {
            return order.Select(t => t.price).Sum();
        }        
    }
}
