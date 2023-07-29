using AutoMapper;
using Employee.Domain.Domains;
using Employee.Domain.Interface;
using Employee.Services.Dtos;
using Employee.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Employee.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository employeeRepository;
        private readonly IMapper mapper;

        public EmployeeService(IEmployeeRepository employeeRepository, IMapper mapper)
        {
            this.employeeRepository = employeeRepository;
            this.mapper = mapper;
        }

        public EmployeeDto Get(Guid empId)
        {
            EmployeeDomain employeeDomain = this.employeeRepository.Get(empId);
            return this.mapper.Map<EmployeeDomain, EmployeeDto>(employeeDomain);
        }

        public List<EmployeeDto> GetAll()
        {
            List<EmployeeDomain> employeeDomains = this.employeeRepository.GetAll();
            return this.mapper.Map<List<EmployeeDto>>(employeeDomains);
        }

        public async Task<EmployeeDto> Create(EmployeeDto employeeDto)
        {
            EmployeeDomain employeeDomain = await this.employeeRepository.Create(this.mapper.Map<EmployeeDomain>(employeeDto));
            return this.mapper.Map<EmployeeDto>(employeeDomain);
        }

        public EmployeeDto Update(EmployeeDto employee)
        {
            EmployeeDomain employeeDomain = this.employeeRepository.Update(this.mapper.Map<EmployeeDomain>(employee));
            return this.mapper.Map<EmployeeDto>(employeeDomain);
        }

        public string Delete(Guid empId)
        {
            EmployeeDomain employeeDomain = this.employeeRepository.Get(empId);
            int result = this.employeeRepository.Delete(employeeDomain);
            return result == 1 ? $"The employee with the id: {empId} has been successfully deleted from db."
                : $"There was problem while deleting employee with the id: {empId} from db.";
        }
    }
}
