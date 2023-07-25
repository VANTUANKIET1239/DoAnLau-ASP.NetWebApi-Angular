using AutoMapper;
using DoAnLau_API.Interface;
using DoAnLau_API.Models;
using Microsoft.AspNetCore.Components.Server.Circuits;

namespace DoAnLau_API.Helper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Menu, MenuDTO>();
            CreateMap<MenuDTO, Menu>();

            CreateMap<MenuCategory, MenuCategoryDTO>();
            CreateMap<MenuCategoryDTO, MenuCategory>();
        }
    }
}
