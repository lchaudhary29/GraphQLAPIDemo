using Employee.Domain.Domains.Common;
using System;
using System.Collections.Generic;

namespace Employee.Domain.Domains
{
    public class DepartmentDomain : EntityDomain
    {
        public string Description { get; set; }

        public DomainEnum.TypeOfDepartment DepartmentType { get; set; }
        //public List<EmployeeDomain> Employees { get; set; }
    }
}