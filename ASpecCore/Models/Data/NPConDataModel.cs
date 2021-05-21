using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ASpecCore.Models.Data
{
    public partial class NPConDataModel : DbContext
    {
        public NPConDataModel() : base(Properties.Settings.Default.NPConConnectionString) { }

        public virtual DbSet<album> Albums { get; set; }
        public virtual DbSet<factory> Factories { get; set; }
        public virtual DbSet<factory_lines> FactoryLinesLink { get; set; }
        public virtual DbSet<Line> FactoryLines { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<factory>()
                .HasMany(e => e.factory_lines)
                .WithRequired(e => e.factory)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Line>()
                .Property(e => e.UID_1c)
                .IsFixedLength();

            modelBuilder.Entity<Line>()
                .Property(e => e.row_ver)
                .IsFixedLength();

            modelBuilder.Entity<Line>()
                .HasMany(e => e.factory_lines)
                .WithRequired(e => e.Line)
                .WillCascadeOnDelete(false);
        }
    }
}
