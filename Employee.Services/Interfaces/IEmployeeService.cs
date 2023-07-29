using Employee.Services.Dtos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Employee.Services.Interfaces
{
    public interface IEmployeeService
    {
        EmployeeDto Get(Guid empId);
        List<EmployeeDto> GetAll();
        Task<EmployeeDto> Create(EmployeeDto employeeDto);
        EmployeeDto Update(EmployeeDto employee);
        string Delete(Guid empId);
    }
}
