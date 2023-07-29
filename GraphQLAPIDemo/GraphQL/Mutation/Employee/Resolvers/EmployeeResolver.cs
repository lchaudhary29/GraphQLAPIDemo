using AutoMapper;
using Employee.Domain.Domains;
using Employee.Domain.Interface;
using Employee.Repository.Repository;
using Employee.Services.Dtos;
using Employee.Services.Interfaces;
using FluentValidation.Results;
using GraphQL;
using GraphQLAPIDemo.GraphQL.GraphQLTypes;
using GraphQLAPIDemo.GraphQL.Mutation.Employee.Validation;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLAPIDemo.GraphQL.Mutation.Employee.Resolvers
{
    public class EmployeeResolver : IEmployeeResolver
    {
        private readonly IResolveFieldContext<object> context;
        private readonly IMapper mapper;
        private IEmployeeService employeeService;

        public EmployeeResolver(IResolveFieldContext<object> context, IMapper mapper, IEmployeeService employeeService)
        {
            this.context = context;
            this.mapper = mapper;
            this.employeeService = employeeService;
        }

        public async Task<EmployeeDto> Create()
        {
            var employeeInput = context.GetArgument<EmployeeInputType>("employee");
            ValidationResult validationResult = await new EmployeeValidator().ValidateAsync(employeeInput);

            if (!validationResult.IsValid)
            {
                validationResult.Errors.ToList().ForEach(e =>
                {
                    context.Errors.Add(new ExecutionError(e.ErrorMessage));
                });

                return await Task.FromResult<EmployeeDto>(null);
            }

            EmployeeDto employeeDto = this.mapper.Map<EmployeeDto>(employeeInput);
            return await this.employeeService.Create(employeeDto);
        }

        public EmployeeDto Update()
        {
            Guid empId;
            if (!Guid.TryParse(context.GetArgument<string>("empId"), out empId))
            {
                context.Errors.Add(new ExecutionError("Invalid EmployeeId passed to the Query"));
            }

            EmployeeDto employeeDto = employeeService.Get(empId);
            if (employeeDto is null)
            {
                context.Errors.Add(new ExecutionError($"Couldn't find the employee with the id {empId}"));
                return null;
            }

            var employee = context.GetArgument<EmployeeDto>("employee");
            employee.Id = empId;
            //employee.Department.Id = employeeDto.Department.Id;

            return this.employeeService.Update(employee);
        }

        public string Delete()
        {
            Guid empId;
            if (!Guid.TryParse(context.GetArgument<string>("empId"), out empId))
            {
                context.Errors.Add(new ExecutionError("Invalid EmployeeId passed to the Query"));
            }

            if (employeeService.Get(empId) is null)
            {
                context.Errors.Add(new ExecutionError($"Couldn't find the employee with the id {empId}"));
                return null;
            }

            return employeeService.Delete(empId);
        }
    }
}
