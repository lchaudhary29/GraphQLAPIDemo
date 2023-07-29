using Employee.Domain.Domains;
using Employee.Services.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Employee.Services.Interfaces
{
    public interface IDepartmentService
    {
        DepartmentDto Get(Guid departmentId);
        public List<DepartmentDto> GetAll();
    }
}
