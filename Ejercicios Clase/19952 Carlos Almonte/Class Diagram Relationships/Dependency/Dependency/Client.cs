using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency
{
    class Client
    {
        public string Naae { get; set; }
        private decimal Budget { get; set; }

        public Client(string name, decimal budget)
        {
            this.Naae = name;
            this.Budget = budget;
        }

        public decimal GetBudget
        {
            get { return this.Budget / 2; }
        }

        public string PrintBudget
        {
            get { return this.Budget.ToString(); }
        }

        public void Spend() { this.Budget -= this.Budget / 4; }

    }
}
