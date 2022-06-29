using AutoMapper;
using EFDataLayer.Entities;
using WebAPIWithEFDB.ApiModel;

namespace WebAPIWithEFDB.MappingConfigurations
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Employee, EmployeeApiModel>().ReverseMap(); ;
            CreateMap<Organization, OrganizationApiModel>().ReverseMap();
        }
    }
}
