using System;

namespace Employee.Domain.Domains.Common
{
    public class EntityDomain : IEntity
    {
        public Guid Id { get; set; }
    }
}
