using Employee.Services.Dtos;
using GraphQL.Types;
using System;
using static Employee.Services.Dtos.DomainEnum;

namespace GraphQLAPIDemo.GraphQL.GraphQLTypes
{
    public class EmployeeInputType : InputObjectGraphType
    {
        public EmployeeInputType()
        {
            Field<NonNullGraphType<StringGraphType>>("name");
            Field<NonNullGraphType<IntGraphType>>("age");
            Field<NonNullGraphType<DateGraphType>>("dob");
            Field<NonNullGraphType<BooleanGraphType>>("isActive");
            Field<NonNullGraphType<DepartmentTypeEnumType>>("departmentId");
        }

        public string Name { get; set; }

        public int Age { get; set; }
        public DateTime Dob { get; set; }
        public bool IsActive { get; set; }
        public TypeOfDepartment DepartmentId { get; set; }
    }
}
