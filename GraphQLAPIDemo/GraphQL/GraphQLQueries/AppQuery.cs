using Employee.Services.Interfaces;
using GraphQL;
using GraphQL.Types;
using GraphQLAPIDemo.GraphQL.GraphQLTypes;
using System;

namespace GraphQLAPIDemo.GraphQL.GraphQLQueries
{
    public class AppQuery : ObjectGraphType
    {
        public AppQuery(IEmployeeService employeeService, IDepartmentService departmentService)
        {
            Field<ListGraphType<EmployeeType>>("employees", resolve: (context) => employeeService.GetAll());
            Field<EmployeeType>("employee",
                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<IdGraphType>>() { Name = "empId" }),
                resolve: (context) =>
            {
                Guid empId;
                if (!Guid.TryParse(context.GetArgument<string>("empId"), out empId))
                {
                    context.Errors.Add(new ExecutionError("Invalid EmpId passed."));
                }

                return employeeService.Get(empId);

            });
            Field<ListGraphType<DepartmentType>>("departments", resolve: (context) => departmentService.GetAll());
        }
    }
}
