using EmployeeManagement.Models.Entities;

namespace EmployeeManagement.Models.DTOs
{
    public class EmployeeDto
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string EmployeeNumber { get; set; }
        public DateTime Birthday { get; set; }
        public DateTime StartDate { get; set; }
        public bool Active { get; set; }
        public string SIN { get; set; }
        public Guid DepartmentId { get; set; }
        public DepartmentDto Department { get; set; } = null!;
    }
}
