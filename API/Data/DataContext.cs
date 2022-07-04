using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext : DbContext
    {
        private readonly DbContextOptions _options;

        public DataContext(DbContextOptions options) : base(options)
        {
            _options = options;
        }

        public DbSet<AppUser> Users { get; set; }
        public DbSet<AppEvent> Events { get; set; }
        public DbSet<AppComment> Comments { get; set; }
    }
}