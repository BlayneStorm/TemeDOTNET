using Microsoft.EntityFrameworkCore;

namespace Classes
{
    public class ApplicationContext : DbContext
    {
        public DbSet<City> Cities {get; set;}
        public DbSet<Poi> Pois {get; set;}

        public ApplicationContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=localhost;Database=Tema5;Trusted_Connection=True;");
            }
        }
    }
}