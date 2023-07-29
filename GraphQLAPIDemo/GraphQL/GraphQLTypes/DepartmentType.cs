using Employee.Services.Dtos;
using GraphQL.Types;

namespace GraphQLAPIDemo.GraphQL.GraphQLTypes
{
    public class DepartmentType : ObjectGraphType<DepartmentDto>
    {
        public DepartmentType()
        {
            Field(d => d.Id, type: typeof(GuidGraphType)).Description("Dept Id");
            Field(d => d.Description, type: typeof(StringGraphType)).Description("Dept Description");
            Field<DepartmentTypeEnumType>("DepartmentType");
        }
    }
}
