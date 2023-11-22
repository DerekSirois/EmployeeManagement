using AutoMapper;
using EmployeeManagement.Models.DTOs;
using EmployeeManagement.Models.Entities;

namespace EmployeeManagement.Config
{
    public class EmployeeProfile : Profile
    {
        public EmployeeProfile()
        {
            CreateMap<Employee, EmployeeDto>().ReverseMap();
            CreateMap<Department, DepartmentDto>().ReverseMap();
        }
    }
}
