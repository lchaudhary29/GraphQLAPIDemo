using Employee.Domain.Domains;
using Microsoft.EntityFrameworkCore;

namespace Employee.Repository
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<EmployeeDomain> Employee { get; set; }
        public DbSet<DepartmentDomain> Department { get; set; }
    }
}
