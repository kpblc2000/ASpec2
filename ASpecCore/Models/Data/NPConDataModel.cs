using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ASpecCore.Models.Data
{
    public partial class NPConDataModel : DbContext
    {
        public NPConDataModel() : base(Properties.Settings.Default.NPConConnectionString) { }

        public virtual DbSet<album> albums { get; set; }
        public virtual DbSet<factory> factories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
