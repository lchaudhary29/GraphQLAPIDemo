using System;

namespace Employee.Services.Dtos.Common
{
    public class EntityDto : IEntity
    {
        public Guid Id { get; set; }
    }
}
