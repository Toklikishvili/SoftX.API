using SoftX.Domain;
using SoftX.Domain.Enumeration;

namespace SoftX.API.Models;

public class EmployeeModel : PersonModel
{
    public int EmployeeId { get; set; }
    public Position Position { get; set; }
    public EmploymentStatus EmploymentStatus { get; set; }
    public string Mobile { get; set; } = string.Empty;
    public DateTime ReleaseDate { get; set; }

    public int UserId { get; set; }
    public User? User { get; set; }
}
