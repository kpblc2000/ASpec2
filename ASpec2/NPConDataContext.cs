using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASpec2
{
    class NPConDataContext : DbContext
    {
        public NPConDataContext() : base(Properties.Settings.Default.NPConConnectionString) { }

        public DbSet<Album> Albums { get; set; }
        public DbSet<Factory> Factories { get; set; }
    }
}
