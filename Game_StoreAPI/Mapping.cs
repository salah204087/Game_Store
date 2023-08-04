using AutoMapper;
using Game_StoreAPI.Models;
using Game_StoreAPI.Models.DTO;

namespace Game_StoreAPI
{
    public class Mapping:Profile
    {
        public Mapping() 
        {
            CreateMap<GameType, GameTypeDTO>().ReverseMap();
            CreateMap<GameType, GameTypeCreateDTO>().ReverseMap();
            CreateMap<GameType, GameTypeUpdateDTO>().ReverseMap();


            CreateMap<GameCompany, GameCompanyDTO>().ReverseMap();
            CreateMap<GameCompany, GameCompanyCreateDTO>().ReverseMap();

            CreateMap<Platform, PlatformDTO>().ReverseMap();
            CreateMap<Platform,PlatformCreateDTO>().ReverseMap();

            CreateMap<Game,GameDTO>().ReverseMap();
            CreateMap<Game,GameCreateDTO>().ReverseMap();
            CreateMap<Game,GameUpdateDTO>().ReverseMap();

            CreateMap<GamePlatform,GamePlatformDTO>().ReverseMap();
            CreateMap<GamePlatform,GamePlatformCreateDTO>().ReverseMap();
            CreateMap<GamePlatform,GamePlatformUpdateDTO>().ReverseMap();

            CreateMap<ApplicationUser, UserDTO>().ReverseMap();
        }
    }
}
