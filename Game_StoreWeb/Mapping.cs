using AutoMapper;
using Game_StoreAPI.Models;
using Game_StoreWeb.Models.DTO;

namespace Game_StoreWeb
{
    public class Mapping:Profile
    {
        public Mapping() 
        {
          
            CreateMap<GameTypeDTO, GameTypeCreateDTO>().ReverseMap();
            CreateMap<GameTypeDTO, GameTypeUpdateDTO>().ReverseMap();


            CreateMap<GameCompanyDTO, GameCompanyCreateDTO>().ReverseMap();

            CreateMap<PlatformDTO,PlatformCreateDTO>().ReverseMap();

            CreateMap<GameDTO,GameCreateDTO>().ReverseMap();
            CreateMap<GameDTO,GameUpdateDTO>().ReverseMap();

            CreateMap<GamePlatformDTO,GamePlatformCreateDTO>().ReverseMap();
            CreateMap<GamePlatformDTO,GamePlatformUpdateDTO>().ReverseMap();

            CreateMap<OrderDTO,Order>().ReverseMap();
            CreateMap<OrderItemDTO,OrderItem>().ReverseMap();
        }
    }
}
