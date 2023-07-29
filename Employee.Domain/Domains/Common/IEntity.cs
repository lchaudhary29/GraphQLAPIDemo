using System;

namespace Employee.Domain.Domains.Common
{
    public interface IEntity
    {
        Guid Id { get; set; }
    }
}