using SoftX.Domain;

namespace SoftX.Facade.Service;

public interface IUserService
{
    object Login(string username, string password);
    object Register(User user);
}
