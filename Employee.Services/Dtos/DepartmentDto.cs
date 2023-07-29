using System.Collections.Generic;
using static Employee.Services.Dtos.DomainEnum;
using Employee.Services.Dtos.Common;

namespace Employee.Services.Dtos
{
    public class DepartmentDto : EntityDto
    {
        public string Description { get; set; }

        public TypeOfDepartment DepartmentType { get; set; }
        public List<EmployeeDto> Employees { get; set; }
    }
}