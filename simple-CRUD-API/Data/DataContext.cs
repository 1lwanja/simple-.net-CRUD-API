global using Microsoft.EntityFrameworkCore;

namespace simple_CRUD_API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext>options) : base(options) 
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=DESKTOP-2VPR9IB;Database=superhero;Trusted_Connection=True;TrustServerCertificate=True;");
        }
        public DbSet<SuperHero> SuperHeroes { get; set; }
    }
}
