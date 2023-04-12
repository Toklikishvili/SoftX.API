using SoftX.Domain.Enumeration;

namespace SoftX.Domain;

public sealed class Employee : Person
{
    public int EmployeeId { get; set; }
    public Position Position { get; set; }
    public EmploymentStatus EmploymentStatus { get; set; }
    public string Mobile { get; set; } = string.Empty;
    public DateTime ReleaseDate { get; set; }

    public int UserId { get; set; }
    public User? User { get; set; }
}
