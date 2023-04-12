using SoftX.Domain;

namespace SoftX.Facade.Repository;

public interface IUserRepository : IRepositoryBase<User>
{
    public object Login(string userName, string password);

    public object Register(User user);
}
