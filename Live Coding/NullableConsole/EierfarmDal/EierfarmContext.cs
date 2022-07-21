using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EierfarmDal
{
    public class EierfarmContext : DbContext
    {
        public EierfarmContext()
        {

        }

        public EierfarmContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Huhn> Huehner { get; set; }
        public DbSet<Ei> Eier { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Huhn>(entity =>
            {
                entity.Property(h => h.Id).ValueGeneratedOnAdd();

                entity.HasMany(h => h.Eier)
                .WithOne(m => m.Mutter)
                .HasForeignKey(e => e.MutterId)
                .HasConstraintName("FK_Huhn_Eier")
                .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Ei>(entity =>
            {
                entity.Property(ei => ei.Id).ValueGeneratedOnAdd();

                //entity.HasOne(m => m.Mutter)
                //.WithMany(e => e.Eier)
                //.HasForeignKey(e => e.MutterId)
                //.HasConstraintName("FK_Eier_Mutter");
            });



            base.OnModelCreating(modelBuilder);
        }
    }
}
