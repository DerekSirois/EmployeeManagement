using EmployeeManagement.Models;
using EmployeeManagement.Models.Entities;

namespace EmployeeManagement.Repositories
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly EmployeeDbContext _context;
        public DepartmentRepository(EmployeeDbContext context)
        {
            _context = context;
        }

        public List<Department> GetAll()
        {
            return _context.Departments.ToList();
        }

        public Department? GetById(Guid id)
        {
            return _context.Departments.Where(d => d.Id == id).FirstOrDefault();
        }
    }
}
