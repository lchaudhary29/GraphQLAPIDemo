using AutoMapper;
using Employee.Domain.Domains;
using Employee.Domain.Interface;
using Employee.Services.Dtos;
using Employee.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Employee.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IDepartmentRepository departmentRepository;
        private readonly IMapper mapper;

        public DepartmentService(IDepartmentRepository departmentRepository, IMapper mapper)
        {
            this.departmentRepository = departmentRepository;
            this.mapper = mapper;
        }

        public DepartmentDto Get(Guid departmentId)
        {
            DepartmentDomain departmentDomain = this.departmentRepository.Get(departmentId);
            return this.mapper.Map<DepartmentDto>(departmentDomain);
        }

        public List<DepartmentDto> GetAll()
        {
            List<DepartmentDomain> departmentDomains = this.departmentRepository.GetAll();
            return this.mapper.Map<List<DepartmentDto>>(departmentDomains);
        }
    }
}
