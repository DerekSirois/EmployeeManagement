using EmployeeManagement.Models.Entities;

namespace EmployeeManagement.Repositories
{
    public interface IEmployeeRepository
    {
        List<Employee> GetAll();
        Employee? GetById(Guid id);
        void Create(Employee employee);
        void Update(Employee employee);
        void Delete(Guid id);
    }
}
