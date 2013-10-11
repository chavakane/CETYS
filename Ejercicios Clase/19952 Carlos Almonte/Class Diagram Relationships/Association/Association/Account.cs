using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association
{
    class Account
    {

        public uint ID { get; set; }
        public string Email { get; set; }

        public Account(uint id, string email)
        {
            this.ID = id;
            this.Email = email;
        }

    }
}
