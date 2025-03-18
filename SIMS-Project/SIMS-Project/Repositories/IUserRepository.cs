using SIMS_Project.Models;

namespace SIMS_Project.Repositories
{
    public interface IUserRepository
    {
        User GetUserByUsername(string username);

        User GetUserByUsernameAndPassword(string username, string password);

        User GetUserByRole(string role);
    }
}
