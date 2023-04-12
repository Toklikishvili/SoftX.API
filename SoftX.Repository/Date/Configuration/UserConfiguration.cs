using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SoftX.Domain;

namespace SoftX.Repository.Date.Configuration;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder
            .HasKey(c => c.UserId);
        builder
            .Property(p => p.PersonalNumber)
            .HasMaxLength(11);
        builder
            .Property(p => p.Email)
            .IsRequired()
            .HasMaxLength(30);
        builder
            .Property(p => p.Password)
            .IsRequired()
            .HasMaxLength(256);
        builder
            .Property(p => p.FirstName)
            .IsRequired()
            .HasMaxLength(20);
        builder
            .Property(p => p.LastName)
            .IsRequired()
            .HasMaxLength(20);
    }
}
