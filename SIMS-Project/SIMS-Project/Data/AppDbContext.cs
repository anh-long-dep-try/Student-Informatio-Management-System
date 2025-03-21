using Microsoft.EntityFrameworkCore;
using SIMS_Project.Models;

namespace SIMS_Project.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        
    }
}
