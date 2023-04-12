using SoftX.Domain;
using SoftX.Facade.Repository;
using SoftX.Facade.Service;

namespace SoftX.Service;

public sealed class EmployeeService : IEmployeeService
{
    private readonly IEmployeeRepository employeeRepository;

    public EmployeeService(IEmployeeRepository employeeRepository)
    {
        this.employeeRepository = employeeRepository ?? throw new ArgumentNullException(nameof(employeeRepository));
    }

    public IEnumerable<Employee> GetAll()
    {
        return employeeRepository.SelectAll();
    }

    public Employee GetById(object id)
    {
        return employeeRepository.Get(id); 
    }

    public IEnumerable<Employee> Search(string text)
    {
        return employeeRepository.Search(x => x.FirstName == text || x.LastName == text);
    }

    public void Create(Employee employee)
    {
        employeeRepository.Insert(employee);
    }

    public void Update(Employee employee)
    {
        employeeRepository.Update(employee);
    }

    public void Delete(object id)
    {
        employeeRepository.Delete(id);
    }
}