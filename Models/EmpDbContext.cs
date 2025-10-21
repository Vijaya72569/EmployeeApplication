using Microsoft.EntityFrameworkCore;

namespace EmployeeWebApplication.Models
{
    public class EmpDbContext : DbContext
    {
        public EmpDbContext(DbContextOptions<EmpDbContext> options) : base(options)
        {
        }
        public DbSet<Emp> Emps { get; set; }
    }
}
