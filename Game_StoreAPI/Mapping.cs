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
        }
    }
}
