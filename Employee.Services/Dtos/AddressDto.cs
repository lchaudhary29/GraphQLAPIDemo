using System.Collections.Generic;
using static Employee.Services.Dtos.DomainEnum;
using Employee.Services.Dtos.Common;
using Employee.Domain.Domains;
using System;

namespace Employee.Services.Dtos
{
    public class AddressDto : EntityDto
    {
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public int Pincode { get; set; }
        public string State { get; set; }
        public string City { get; set; }
    }
}