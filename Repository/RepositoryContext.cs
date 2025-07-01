using Microsoft.EntityFrameworkCore;
using OscBackend.Models;

namespace OscBackend.Repository
{
    public class RepositoryContext(DbContextOptions options) : DbContext(options)
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<OngLocation> OngLocations { get; set; }
    }
}
