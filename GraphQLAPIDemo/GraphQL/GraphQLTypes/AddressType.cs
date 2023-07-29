using Employee.Services.Dtos;
using Employee.Services.Interfaces;
using GraphQL.Types;
using static Employee.Services.Dtos.DomainEnum;

namespace GraphQLAPIDemo.GraphQL.GraphQLTypes
{
    public class AddressType : ObjectGraphType<AddressDto>
    {
        public AddressType(IDepartmentService departmentService)
        {
            Field(e => e.Id, type: typeof(GuidGraphType)).Description("Employee Id");
            Field(e => e.Address1, type: typeof(StringGraphType)).Description("Address 1");
            Field(e => e.Address2, type: typeof(StringGraphType)).Description("Address 2");
            Field(e => e.Pincode, type: typeof(IntGraphType)).Description("Pincode");
            Field(e => e.State, type: typeof(StringGraphType)).Description("State");
            Field(e => e.City, type: typeof(StringGraphType)).Description("City");
        }
    }
}
