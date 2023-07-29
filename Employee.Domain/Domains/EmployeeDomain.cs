using Employee.Domain.Domains.Common;
using System;

namespace Employee.Domain.Domains
{
    public class EmployeeDomain : EntityDomain
    {
        public string Name { get; set; }

        public int Age { get; set; }
        public DateTime Dob { get; set; }
        public bool IsActive { get; set; }
        public int DepartmentId { get; set; }

    }
}
