using EntityFramework.Model;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework.DAL
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=localhost,1433; Database=EntityFramework; User=sa; Password=Appelsin13Appelsin; TrustServerCertificate=True; MultipleActiveResultSets=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bil>().HasData(new Bil[] {
                new Bil{BilID = 1, Name = "BMW", Weight = 1400 }
            });

            modelBuilder.Entity<Hobbyfly>()
                .HasMany(f => f.Ejere)
                .WithMany(p => p.Hobbyfly)
                .UsingEntity(j => j.ToTable("HobbyflyEjer"));
        }

        public DbSet<Bil> Biler { get; set; }
        public DbSet<Ejer> Ejer { get; set; }
        public DbSet<Hobbyfly> Hobbyfly { get; set; }
    }
}