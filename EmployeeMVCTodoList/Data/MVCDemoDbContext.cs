using EmployeeMVCTodoList.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace EmployeeMVCTodoList.Data
{
    public class MVCDemoDbContext : DbContext
    {
        public MVCDemoDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
