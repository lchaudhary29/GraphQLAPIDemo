using Employee.Domain.Domains;
using Employee.Domain.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee.Repository.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ApplicationContext context;

        public EmployeeRepository(ApplicationContext context)
        {
            this.context = context;
        }

        public EmployeeDomain Get(Guid empId)
        {
            return context.Employee.SingleOrDefault(e => e.Id == empId);
        }

        public List<EmployeeDomain> GetAll()
        {
            return context.Employee.ToList();
        }

        public async Task<EmployeeDomain> Create(EmployeeDomain employee)
        {
            employee.Id = Guid.NewGuid();
            context.Add(employee);
            await context.SaveChangesAsync();
            return employee;
        }

        public EmployeeDomain Update(EmployeeDomain employee)
        {
            context.SaveChanges();

            return employee;
        }
        public int Delete(EmployeeDomain employee)
        {
            context.Employee.Remove(employee);
            return context.SaveChanges();
        }

    }
}
