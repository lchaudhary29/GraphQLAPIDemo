using Employee.Services.Dtos;
using GraphQLAPIDemo.GraphQL.GraphQLTypes;
using System.Threading.Tasks;

namespace GraphQLAPIDemo.GraphQL.Mutation.Employee.Resolvers
{
    public interface IEmployeeResolver
    {
        Task<EmployeeDto> Create();
        EmployeeDto Update();
        string Delete();
    }
}