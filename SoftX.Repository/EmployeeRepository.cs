using SoftX.Domain;
using SoftX.Facade.Repository;
using SoftX.Repository.Date;

namespace SoftX.Repository;

public sealed class EmployeeRepository : RepositoryBase<Employee>, IEmployeeRepository
{
    public EmployeeRepository(SoftXDbContext context) : base(context)
    {
    }
}
