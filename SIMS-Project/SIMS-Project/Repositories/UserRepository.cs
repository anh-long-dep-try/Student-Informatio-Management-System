using Microsoft.EntityFrameworkCore;
using SIMS_Project.Data;
using SIMS_Project.Models;
using System.Linq.Expressions;

namespace SIMS_Project.Repositories
{
    public class UserRepository : SingletonRepository<User>, IUserRepository
    {
        public UserRepository() : base()
        {
        }

        public IEnumerable<User> GetAllUsers()
        {
            try
            {
                return GetAll();
            }
            catch (Exception ex)
            {
                return Enumerable.Empty<User>();
            }
        }

        public User GetUserById(int id)
        {
            try
            {
                return GetById(id);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public User GetUserByUsernameAndPassword(string username, string password)
        {
            try
            {
                return Find(u => u.Username == username && u.Password == password).FirstOrDefault();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public bool CreateUser(User user)
        {
            try
            {
                Add(user);
                SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool UpdateUser(User user)
        {
            try
            {
                Update(user);
                SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool DeleteUser(int id)
        {
            try
            {
                var user = GetById(id);
                if (user != null)
                {
                    Delete(user);
                    SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}