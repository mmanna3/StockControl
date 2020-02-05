using Microsoft.EntityFrameworkCore;
using StockControl.Models;

namespace StockControl.Persistence
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Articulo> Articulos { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Articulo>()
                .Property(a => a.CodigoDeBarras)
                .HasMaxLength(255)
                .IsRequired();

            builder.Entity<Articulo>()
                .Property(a => a.Descripcion)
                .HasMaxLength(255)
                .IsRequired();

            builder.Entity<Articulo>()
                .Property(a => a.Precio)
                .HasColumnType("decimal(7,2)");
            
            builder.Entity<Articulo>()
                .HasIndex(u => u.CodigoDeBarras)                
                .IsUnique();

            builder.Entity<Proveedor>()
                .Property(a => a.Descripcion)
                .HasMaxLength(255)
                .IsRequired();
        }
    }
}