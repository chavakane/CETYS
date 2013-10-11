using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency
{
    class Suplier
    {
        private decimal PartialBudget { get; set; }
        public string Name { get; set; }
        private Client TheClient { get; set; }

        public Suplier(string name, decimal budget, Client client)
        {
            this.Name = name;
            this.PartialBudget = budget;
            this.TheClient = client;
        }

        public decimal TotalBudget
        {
            get { return this.PartialBudget + this.TheClient.GetBudget; }
        }

    }
}
