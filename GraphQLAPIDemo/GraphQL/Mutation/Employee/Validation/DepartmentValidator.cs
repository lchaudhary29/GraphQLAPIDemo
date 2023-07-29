using Employee.Services.Dtos;
using FluentValidation;
using GraphQLAPIDemo.GraphQL.GraphQLTypes;

namespace GraphQLAPIDemo.GraphQL.Mutation.Employee.Validation
{
    public class DepartmentValidator : AbstractValidator<DepartmentTypeInput>
    {
        public DepartmentValidator()
        {
            RuleFor(d => d.DepartmentType).NotEmpty();
        }
    }
}
