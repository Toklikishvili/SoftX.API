namespace SoftX.Domain;

public sealed class User : Person
{
    public int UserId { get; set; }
    public string Email { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;

    public ICollection<Employee>? Employees { get; set; }
}
