using Employee.Domain.Domains.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Employee.Domain.Domains
{
    public class AddressDomain : EntityDomain
    {
        public Guid EmployeeId { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public int Pincode { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public EmployeeDomain Employee { get; set; }

    }
}
