using EmployeeManagement.Models.DTOs;

namespace EmployeeManagement.Services
{
    public interface IEmployeeService
    {
        void Create(EmployeeDto employeeDto);
        void Delete(Guid id);
        List<EmployeeDto> GetAll();
        EmployeeDto GetById(Guid id);
        void Update(EmployeeDto employeeDto);
    }
}