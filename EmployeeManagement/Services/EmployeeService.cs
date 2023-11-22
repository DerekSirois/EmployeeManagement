using AutoMapper;
using EmployeeManagement.Models.DTOs;
using EmployeeManagement.Models.Entities;
using EmployeeManagement.Repositories;

namespace EmployeeManagement.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _repository;
        private readonly IMapper _mapper;

        public EmployeeService(IMapper mapper, IEmployeeRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public List<EmployeeDto> GetAll()
        {
            var employees = _repository.GetAll();
            var employeesDto = _mapper.Map<List<EmployeeDto>>(employees);
            return employeesDto;
        }

        public EmployeeDto GetById(Guid id)
        {
            var employee = _repository.GetById(id);
            var employeeDto = _mapper.Map<EmployeeDto>(employee);
            return employeeDto;
        }

        public void Create(EmployeeDto employeeDto)
        {
            var employee = _mapper.Map<Employee>(employeeDto);
            _repository.Create(employee);
        }

        public void Update(EmployeeDto employeeDto)
        {
            var employee = _mapper.Map<Employee>(employeeDto);
            _repository.Update(employee);
        }

        public void Delete(Guid id)
        {
            _repository.Delete(id);
        }
    }
}
