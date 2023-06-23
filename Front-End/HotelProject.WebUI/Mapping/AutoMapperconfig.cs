using AutoMapper;
using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.DTOs.AboutDTO;
using HotelProject.WebUI.DTOs.LoginDTO;
using HotelProject.WebUI.DTOs.RegisterDTO;
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


            CreateMap<CreateNewUserDto, AppUser>().ReverseMap();
            CreateMap<LoginUserDto, AppUser>().ReverseMap();

            CreateMap<ResultAboutDto, About>().ReverseMap();
            CreateMap<UpdateAboutDto, About>().ReverseMap();


        }
    }
}
