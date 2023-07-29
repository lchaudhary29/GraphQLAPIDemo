using Employee.Domain.Domains;
using System;
using System.Collections.Generic;


namespace Employee.Domain.Interface
{
    public interface IDepartmentRepository
    {
        DepartmentDomain Get(Guid departmentId);
        public List<DepartmentDomain> GetAll();
    }
}
