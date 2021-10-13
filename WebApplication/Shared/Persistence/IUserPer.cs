using WebApplication.Shared.Models;

namespace WebApplication.Shared.Persistence
{
    public interface IUserPer
    {
        void CreateUser(User user);
        User ValidateUser(string username, string password);
    }
}