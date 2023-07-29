using GraphQL.Types;
using static Employee.Domain.Domains.DomainEnum;

namespace GraphQLAPIDemo.GraphQL.GraphQLTypes
{
    public class DepartmentTypeInput : InputObjectGraphType
    {
        public DepartmentTypeInput()
        {
            Field<NonNullGraphType<StringGraphType>>("description");
            Field<NonNullGraphType<DepartmentTypeEnumType>>("departmentType");
        }

        public new string Description { get; set; }
        public TypeOfDepartment DepartmentType { get; set; }
    }
}
