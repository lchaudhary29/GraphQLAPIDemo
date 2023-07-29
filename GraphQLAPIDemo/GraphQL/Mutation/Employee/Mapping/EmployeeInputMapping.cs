using AutoMapper;
using Employee.Domain.Domains;
using Employee.Services.Dtos;
using GraphQLAPIDemo.GraphQL.GraphQLTypes;

namespace GraphQLAPIDemo.GraphQL.Mutation.Employee.Mapping
{
    public class EmployeeInputMapping : Profile
    {
        public EmployeeInputMapping()
        {
            CreateMap<DepartmentTypeInput, DepartmentDto>();
            CreateMap<EmployeeInputType, EmployeeDto>();
        }
    }
}
