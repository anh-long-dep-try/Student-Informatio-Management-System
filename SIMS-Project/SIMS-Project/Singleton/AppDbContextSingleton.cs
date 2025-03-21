using SIMS_Project.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace SIMS_Project.Singleton
{
    public class AppDbContextSingleton
    {
        private static AppDbContext _instance;
        private static readonly object _lock = new object();

        private AppDbContextSingleton() { }

        public static AppDbContext Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            var configuration = new ConfigurationBuilder()
                                .SetBasePath(Directory.GetCurrentDirectory())
                                .AddJsonFile("appsettings.json")
                                .Build();

                            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
                            optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));

                            _instance = new AppDbContext(optionsBuilder.Options);
                        }
                    }
                }
                return _instance;
            }
        }

        // Method to reset the instance (useful for testing)
        public static void ResetInstance()
        {
            lock (_lock)
            {
                _instance?.Dispose();
                _instance = null;
            }
        }
    }
}