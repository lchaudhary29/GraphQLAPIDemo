namespace GraphQLAPIDemo.GraphQL.Mutation.Employee.Validation
{
    using FluentValidation;
    using global::Employee.Services.Dtos;
    using GraphQLAPIDemo.GraphQL.GraphQLTypes;

    public class EmployeeValidator : AbstractValidator<EmployeeInputType>
    {
        public EmployeeValidator()
        {
            RuleFor(e => e.Age)
                .NotEmpty()
                .InclusiveBetween(1, 100);

            //RuleFor(e => e.Department.DepartmentType)
            //    .IsInEnum()
            //    .WithMessage("Department naem is not correct");

            //RuleFor(e => e.Department)
            //  .SetValidator(new DepartmentValidator());
        }
    }
}
