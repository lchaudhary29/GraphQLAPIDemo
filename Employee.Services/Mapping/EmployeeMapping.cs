using AutoMapper;
using Employee.Domain.Domains;
using Employee.Domain.Domains.Common;
using Employee.Services.Dtos;
using Employee.Services.Dtos.Common;

namespace Employee.Services.Mapping
{
    public class EmployeeMapping : Profile
    {
        public EmployeeMapping()
        {
            //CreateMap<EntityDomain, EntityDto>();

            CreateMap<EmployeeDomain, EmployeeDto>()
                //.IncludeBase<EntityDomain, EntityDto>()
                .AfterMap((domain, dto) =>
                {

                })
                .ReverseMap();
        }
    }
}
