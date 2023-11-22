using EmployeeManagement.Models;
using EmployeeManagement.Models.Entities;

namespace EmployeeManagement.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly EmployeeDbContext _context;
        public EmployeeRepository(EmployeeDbContext context)
        {
            _context = context;
        }

        public List<Employee> GetAll()
        {
            return _context.Employees.ToList();
        }

        public Employee? GetById(Guid id)
        {
            return _context.Employees.Where(e => e.Id == id).FirstOrDefault();
        }

        public void Create(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
        }

        public void Update(Employee employee)
        {
            _context.Employees.Update(employee);
            _context.SaveChanges();
        }

        public void Delete(Guid id)
        {
            var employee = GetById(id);
            _context.Employees.Remove(employee!);
            _context.SaveChanges();
        }
    }
}
