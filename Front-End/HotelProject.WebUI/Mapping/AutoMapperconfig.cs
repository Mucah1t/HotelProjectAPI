using AutoMapper;
using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.DTOs.ServiceDTO;

namespace HotelProject.WebUI.Mapping
{
    public class AutoMapperconfig:Profile
    {
        public AutoMapperconfig()
        {
            CreateMap<ResultServiceDto, Service>().ReverseMap();
            CreateMap<UpdateServiceDto, Service>().ReverseMap();
            CreateMap<CreateServiceDto, Service>().ReverseMap();

        }
    }
}
