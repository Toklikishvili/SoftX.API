using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SoftX.Domain;

namespace SoftX.Repository.Date.Configuration;

public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
{
    public void Configure(EntityTypeBuilder<Employee> builder)
    {
        builder
            .HasOne(u => u.User)
            .WithMany(e => e.Employees)
            .HasForeignKey(e => e.UserId);
        builder
            .HasKey(c => c.EmployeeId);
        builder
            .Property(e => e.PersonalNumber)
            .IsRequired()
            .HasMaxLength(11);
        builder
            .Property(e => e.FirstName)
            .IsRequired()         
            .HasMaxLength(20);
        builder
            .Property(e => e.LastName)
            .IsRequired()
            .HasMaxLength(20);
        builder
            .Property(e => e.Gender)
            .IsRequired()
            .HasMaxLength(10);
        builder
            .Property(e => e.Mobile)
            .IsRequired()
            .HasMaxLength(30);

    }
}
