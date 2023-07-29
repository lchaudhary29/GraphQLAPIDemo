using AutoMapper;
using Employee.Domain.Domains;
using Employee.Domain.Domains.Common;
using Employee.Services.Dtos;
using Employee.Services.Dtos.Common;

namespace Employee.Services.Mapping
{
    public class AddressMapping : Profile
    {
        public AddressMapping()
        {
            CreateMap<AddressDomain, AddressDto>()
                .ReverseMap();
        }
    }
}
