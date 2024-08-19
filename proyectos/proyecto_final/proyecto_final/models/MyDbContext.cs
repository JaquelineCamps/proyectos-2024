using Microsoft.EntityFrameworkCore;
using proyecto_final.models;

namespace proyecto_final.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() { }

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Pelicula> Peliculas { get; set; }
        public DbSet<Alquiler> Alquileres { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Cliente>().HasKey(e => e.IdCliente);
            modelBuilder.Entity<Pelicula>().HasKey(c => c.IdPelicula);
            modelBuilder.Entity<Alquiler>().HasKey(c => c.IdAlquiler);

        }
    }

}
