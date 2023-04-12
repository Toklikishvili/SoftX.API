using SoftX.Domain;
using SoftX.Facade.Repository;
using SoftX.Repository.Date;

namespace SoftX.Repository;

public sealed class UserRepository : RepositoryBase<User>, IUserRepository
{
    public UserRepository(SoftXDbContext context) : base(context)
    {
    }

    public object Login(string userName, string password)
    {
        if (IsExistsUser(userName))
            return "This user does not exist";
        return CheckUser(userName, password); ;
    }

    public object Register(User user)
    {
        _context.Add(user);
        _context.SaveChanges();

        return user.UserId;
    }

    private bool IsExistsUser(string userName)
    {
        return _context.Users.Any(u => u.Email == userName);
    }
    private object CheckUser(string userName, string password)
    {
        var user = _context.Users.FirstOrDefault(u => u.Email == userName && u.Password == password);
        if (user == null)
            return "Username or password is incorrect!";

        return user.UserId;
    }
}
