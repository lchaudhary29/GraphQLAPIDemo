using Employee.Domain.Domains.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Employee.Domain.Domains
{
    public class EmployeeDomain : EntityDomain
    {
        public string Name { get; set; }

        public int Age { get; set; }
        public DateTime Dob { get; set; }
        public bool IsActive { get; set; }
        public int DepartmentId { get; set; }

        public List<AddressDomain> Address { get; set; }
    }
}
