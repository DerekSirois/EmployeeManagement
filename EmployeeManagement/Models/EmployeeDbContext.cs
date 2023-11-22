using EmployeeManagement.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace EmployeeManagement.Models
{
    public class EmployeeDbContext : DbContext
    {
        public DbSet<Department> Department { get; set; }
        public DbSet<Employee> Employees { get; set; }

        public EmployeeDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>()
                .HasMany(e => e.Employees)
                .WithOne(e => e.Department)
                .HasForeignKey(e => e.DepartmentId)
                .IsRequired(false);
        }
    }
}
