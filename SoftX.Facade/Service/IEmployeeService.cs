using SoftX.Domain;

namespace SoftX.Facade.Service;

public interface IEmployeeService
{
    IEnumerable<Employee> GetAll();
    IEnumerable<Employee> Search(string text);
    Employee GetById(object id);
    void Create(Employee employee);
    void Update(Employee employee);
    void Delete(object id);
}