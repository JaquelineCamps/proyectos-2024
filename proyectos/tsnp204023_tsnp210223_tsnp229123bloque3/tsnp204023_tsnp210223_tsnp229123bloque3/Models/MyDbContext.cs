using Microsoft.EntityFrameworkCore;

namespace tsnp204023_tsnp210223_tsnp229123bloque3.Models
{
    public class MyDbContext(DbContextOptions<MyDbContext> options) : DbContext(options)
    {
        public DbSet<Peliculas> Peliculas { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Peliculas>().HasKey(c => c.IdPelicula);
        }

    }
}
