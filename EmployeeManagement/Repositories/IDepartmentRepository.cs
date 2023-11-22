using EmployeeManagement.Models.Entities;

namespace EmployeeManagement.Repositories
{
    public interface IDepartmentRepository
    {
        List<Department> GetAll();
        Department? GetById(Guid id);
    }
}
