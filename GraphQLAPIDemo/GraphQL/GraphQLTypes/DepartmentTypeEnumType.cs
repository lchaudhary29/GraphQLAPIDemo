using GraphQL.Types;
using static Employee.Domain.Domains.DomainEnum;

namespace GraphQLAPIDemo.GraphQL.GraphQLTypes
{
    public class DepartmentTypeEnumType : EnumerationGraphType<TypeOfDepartment>
    {
        public DepartmentTypeEnumType()
        {
            //Name = "DepartmentType";
            //Description = "Enumeration for the Department type object";
        }
    }
}
