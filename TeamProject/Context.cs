using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamProject
{
    class Context: DbContext
    {
        public DbSet<Orders> Orders { get; set; }
        public DbSet<Performers> Performers { get; set; }
        public DbSet<Customers> Customers { get; set; }
    }
}
