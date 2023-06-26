using eCinema.Model;

namespace eCinema.Services.Interfaces
{
    public interface IUserService
    {
        IEnumerable<User> GetAllUsers();
    }
}
