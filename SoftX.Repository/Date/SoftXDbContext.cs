using Microsoft.EntityFrameworkCore;
using SoftX.Domain;
using SoftX.Repository.Date.Configuration;

namespace SoftX.Repository.Date;

public class SoftXDbContext : DbContext
{
    public SoftXDbContext(DbContextOptions options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfiguration(new UserConfiguration());
        modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
    }

    public DbSet<User>? Users { get; set; }
    public DbSet<Employee>? Employees { get; set; }
}
