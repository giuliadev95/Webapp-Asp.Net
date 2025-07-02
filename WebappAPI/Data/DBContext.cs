using Microsoft.EntityFrameworkCore;
using WebappAPI.Models.Domain;

// This creates the 3 tables I need in SQL Server with Entity Framework
namespace WebappAPI.Data
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }

        public DbSet<Difficulty> Difficulties { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk> Walks { get; set; }
    }
}
