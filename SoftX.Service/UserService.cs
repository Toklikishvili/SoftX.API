using SoftX.Domain;
using SoftX.Facade.Repository;
using SoftX.Facade.Service;

namespace SoftX.Service;

public sealed class UserService : IUserService
{
    private readonly IUserRepository userRepository;

    public UserService(IUserRepository userRepository)
    {
        this.userRepository = userRepository ?? throw new ArgumentNullException(nameof(userRepository));
    }

    public object Login(string username, string password) =>
        userRepository.Login(username, password);


    public object Register(User user) =>
        userRepository.Register(user);
}
