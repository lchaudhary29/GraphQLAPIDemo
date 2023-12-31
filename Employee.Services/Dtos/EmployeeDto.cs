﻿using Employee.Domain.Domains;
using Employee.Services.Dtos.Common;
using System;
using System.Collections.Generic;
using static Employee.Services.Dtos.DomainEnum;

namespace Employee.Services.Dtos
{
    public class EmployeeDto : EntityDto
    {
        public string Name { get; set; }

        public int Age { get; set; }
        public DateTime Dob { get; set; }
        public bool IsActive { get; set; }
        public TypeOfDepartment DepartmentId { get; set; }
        public List<AddressDto> Address { get; set; }
    }
}
