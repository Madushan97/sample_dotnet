using Microsoft.EntityFrameworkCore;
using MyApp.models;

namespace MySqlSampleApp
{
    public class MyDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Replace the connection string with your actual MySQL connection string
            optionsBuilder.UseMySql("server=localhost;database=MyTestDB;user=root;password=madushan", 
                new MySqlServerVersion(new Version(8, 0, 25)));
        }
    }
}
