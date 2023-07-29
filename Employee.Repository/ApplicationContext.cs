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
        public DbSet<AddressDomain> Address { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmployeeDomain>()
           .HasMany<AddressDomain>(x => x.Address)
           .WithOne(x => x.Employee)
           .HasForeignKey(x => x.EmployeeId);
        }
    }
}
