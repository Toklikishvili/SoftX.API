using SoftX.Domain.Enumeration;

namespace SoftX.Domain;

public abstract class Person
{
    public string PersonalNumber { get; set; } = string.Empty;
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public DateTime DateOfBirth { get; set; }
    public Gender Gender { get; set; }
}