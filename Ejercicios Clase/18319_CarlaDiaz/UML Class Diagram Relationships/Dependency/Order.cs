using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Order
    {
        Dictionary<string, decimal> products;
        decimal subtotal;
        decimal total;

        public Dictionary<string, decimal> Products 
        {
            get { return products; }
        }

        public decimal Total 
        {
            get { return total; }
        }

        public Order(Dictionary<string, decimal> products)
        {
            this.products = products;
            this.subtotal = Calculator.GetSubtotal(this.products);
            this.total = Calculator.GetTotal(subtotal, 10);
        }
    }
}
