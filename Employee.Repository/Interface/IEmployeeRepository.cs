using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Employee.Domain.Domains;



namespace Employee.Domain.Interface
{
    public interface IEmployeeRepository
    {
        EmployeeDomain Get(Guid empId);
        List<EmployeeDomain> GetAll();
        Task<EmployeeDomain> Create(EmployeeDomain employee);

        EmployeeDomain Update(EmployeeDomain employee);

        int Delete(EmployeeDomain employee);
    }
}
