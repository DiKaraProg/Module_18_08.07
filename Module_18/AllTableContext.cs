using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_18
{
    public class AllTableContext : DbContext 
    {
        public AllTableContext(): base("MyDb1") { }
        public DbSet<Client> Clients { get; set; }
        public  DbSet<Order> Orders { get; set; }
        public DbSet<Templete> templetes { get; set; }
    }
}
