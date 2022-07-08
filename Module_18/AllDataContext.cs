using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_18
{
    class ClientContext : DbContext
    {
        public ClientContext():base("MyDb")
        {

        }
        //public DbSet<Order> orders { get; set; }
        public DbSet<Client> clients { get; set; }
    }
}
