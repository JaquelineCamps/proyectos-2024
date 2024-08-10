using Microsoft.EntityFrameworkCore;

namespace peliculas.Models
{
    public class MyDbContext(DbContextOptions<MyDbContext>options) : DbContext(options)
    {
        public DbSet<Pelicula> Peliculas { get; set; }
        public DbSet<Producto> Productos { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Pelicula>().HasKey(c => c.IdPelicula);
            modelBuilder.Entity<Producto>().HasKey(c => c.IdProducto);
        }
    }
    }
    

    

