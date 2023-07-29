using Employee.Services.Dtos;
using Employee.Services.Interfaces;
using GraphQL.Types;
using static Employee.Services.Dtos.DomainEnum;

namespace GraphQLAPIDemo.GraphQL.GraphQLTypes
{
    public class EmployeeType : ObjectGraphType<EmployeeDto>
    {
        public EmployeeType(IDepartmentService departmentService)
        {
            Field(e => e.Id, type: typeof(GuidGraphType)).Description("Employee Id");
            Field(e => e.Name, type: typeof(StringGraphType)).Description("Employee Name");
            Field(e => e.Age, type: typeof(IntGraphType)).Description("Employee Age");
            Field(e => e.Dob, type: typeof(DateGraphType)).Description("Employee Dob");
            Field(e => e.IsActive, type: typeof(BooleanGraphType)).Description("Employee Active");
            Field(e => e.DepartmentId, type: typeof(DepartmentTypeEnumType)).Description("DepartmentId");
            Field(e => e.Address, type: typeof(ListGraphType<AddressType>)).Description("Addresses");
            //Field<DepartmentType>("department", resolve: (context) => departmentService.Get(context.Source.DepartmentType));
        }
    }
}
