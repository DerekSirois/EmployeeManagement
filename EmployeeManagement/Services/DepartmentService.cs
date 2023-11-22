using AutoMapper;
using EmployeeManagement.Models.DTOs;
using EmployeeManagement.Repositories;

namespace EmployeeManagement.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IMapper _mapper;
        private readonly IDepartmentRepository _repository;

        public DepartmentService(IMapper mapper, IDepartmentRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public List<DepartmentDto> GetAll()
        {
            var department = _repository.GetAll();
            var departmentDto = _mapper.Map<List<DepartmentDto>>(department);
            return departmentDto;
        }

        public DepartmentDto GetById(Guid id)
        {
            var department = _repository.GetById(id);
            var departmentDto = _mapper.Map<DepartmentDto>(department);
            return departmentDto;
        }
    }
}
