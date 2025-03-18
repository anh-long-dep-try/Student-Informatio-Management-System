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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 3,
                    Username = "bcd",
                    Password = "admin",
                    Email = "bcd@email.com"
                });
        }
    }
}
