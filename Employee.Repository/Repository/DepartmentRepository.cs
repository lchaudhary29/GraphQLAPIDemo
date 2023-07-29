using Employee.Domain.Domains;
using Employee.Domain.Interface;
using Employee.Repository;
using System;
using System.Collections.Generic;
using System.Linq;


namespace GraphQLAPIDemo.Repository
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly ApplicationContext context;

        public DepartmentRepository(ApplicationContext context)
        {
            this.context = context;
        }

        public DepartmentDomain Get(Guid departmentId)
        {
            return this.context.Department.FirstOrDefault(x => x.Id == departmentId);
        }

        List<DepartmentDomain> IDepartmentRepository.GetAll()
        {
            return this.context.Department.ToList();
        }
    }
}
