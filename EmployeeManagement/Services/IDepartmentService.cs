using EmployeeManagement.Models.DTOs;

namespace EmployeeManagement.Services
{
    public interface IDepartmentService
    {
        List<DepartmentDto> GetAll();
        DepartmentDto GetById(Guid id);
    }
}