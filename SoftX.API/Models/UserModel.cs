using SoftX.Domain;

namespace SoftX.API.Models;

public class UserModel : PersonModel
{
    public string Email { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;

    public ICollection<Employee>? Employees { get; set; }
}

