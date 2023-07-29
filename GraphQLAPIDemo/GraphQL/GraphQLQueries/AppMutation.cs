using AutoMapper;
using Employee.Services.Dtos;
using Employee.Services.Interfaces;
using GraphQL;
using GraphQL.Types;
using GraphQLAPIDemo.GraphQL.GraphQLTypes;
using GraphQLAPIDemo.GraphQL.Mutation.Employee.Resolvers;
using System;

namespace GraphQLAPIDemo.GraphQL.GraphQLQueries
{
    public class AppMutation : ObjectGraphType
    {
        public AppMutation(IEmployeeService employeeService, IMapper mapper)
        {
            FieldAsync<EmployeeType>(
                "createEmployee",
                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<EmployeeInputType>>() { Name = "employee" }),
                resolve: async context => await new EmployeeResolver(context, mapper, employeeService).Create());

            Field<EmployeeType>("updateEmployee",
                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<EmployeeInputType>>() { Name = "employee" }
                , new QueryArgument<NonNullGraphType<StringGraphType>>() { Name = "empId" }),
                resolve: (context) => new EmployeeResolver(context, mapper, employeeService).Update());

            Field<StringGraphType>("deleteEmployee",
                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<StringGraphType>>() { Name = "empId" }),
                resolve: (context) => new EmployeeResolver(context, mapper, employeeService).Delete());
        }
    }
}
