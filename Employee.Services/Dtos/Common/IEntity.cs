using System;

namespace Employee.Services.Dtos.Common
{
    public interface IEntity
    {
        Guid Id { get; set; }
    }
}