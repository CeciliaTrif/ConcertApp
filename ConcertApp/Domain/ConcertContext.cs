using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ConcertApp.Domain
{
    public class ConcertContext : IdentityDbContext
    {
        public DbSet<Band> Bands { get; set; }
        public DbSet<Musician> Musicians { get; set; }
        public ConcertContext(DbContextOptions<ConcertContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            ConcertConfiguration(modelBuilder);
        }

        protected void ConcertConfiguration(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Band>()
                .ToTable("Bands");

            modelBuilder.Entity<Band>()
                .HasKey(band => band.BandId);

            modelBuilder.Entity<Band>()               
                .Property(band => band.Name)
                .HasColumnName("Name")
                .HasMaxLength(20);
        }
    }
}
