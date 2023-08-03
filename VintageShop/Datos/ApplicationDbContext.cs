using Microsoft.EntityFrameworkCore;
using VintageShop.Entidades;

namespace VintageShop.Datos
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Zapato>  Zapatos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Zapato>()
                .HasKey(x => x.Id);

            modelBuilder.Entity<Zapato>()
                .Property(x => x.Name)
                .IsRequired();

            modelBuilder.Entity<Zapato>()
                .Property(x => x.Img)
                .IsRequired();

            modelBuilder.Entity<Zapato>()
                .Property(x => x.Price)
                .IsRequired();

        }
    }
}
