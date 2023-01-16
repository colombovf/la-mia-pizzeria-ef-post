using LaMiaPizzeria.Models;
using Microsoft.EntityFrameworkCore;

namespace LaMiaPizzeria.Database
{
    public class PizzaContext : DbContext
    {
        public DbSet<Pizza> Pizze { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;Database=MenuPizzeria;" +
            "Integrated Security=True;TrustServerCertificate=True");
        }

        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pizza>()
                .HasNoKey();
        }*/
    }
}
