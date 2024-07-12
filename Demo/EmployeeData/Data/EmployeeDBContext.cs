using EmployeeData.Models.DBEntities;
using Microsoft.EntityFrameworkCore;

namespace EmployeeData.Data
{
    public class EmployeeDBContext : DbContext
    {
        public EmployeeDBContext(DbContextOptions options) : base(options)
        {
        }

       public DbSet<Employee> Employees { get; set; }
    }
}
