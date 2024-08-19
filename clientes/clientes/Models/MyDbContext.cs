using Microsoft.EntityFrameworkCore;

namespace clientes.Models
{
    public class MyDbContext(DbContextOptions<MyDbContext> options) : DbContext(options)
    {

        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Cliente>().HasKey(c => c.IdCliente);
        }


    }
}