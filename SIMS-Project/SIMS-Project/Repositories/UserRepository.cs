using Microsoft.EntityFrameworkCore;
using SIMS_Project.Data;
using SIMS_Project.Models;

namespace SIMS_Project.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
        public User GetUserByUsername(string username)
        {
            return _dbSet.FirstOrDefault(u => u.Username == username);
        }

        public User GetUserByUsernameAndPassword(string username, string password)
        {
            return _dbSet.FirstOrDefault(u => u.Username == username && u.Password == password);
        }
        public User GetUserByRole(string role)
        {
            return _dbSet.FirstOrDefault(u => u.UserRole == role);
        }
    }
}
