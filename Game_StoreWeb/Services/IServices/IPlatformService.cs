using Game_StoreWeb.Models.DTO;

namespace Game_StoreWeb.Services.IServices
{
    public interface IPlatformService
    {
        Task<T>GetAllAsync<T>(string token);
        Task<T>GetAsync<T>(int id,string token);
        Task<T>CreateAsync<T>(PlatformCreateDTO platformCreateDTO,string token);
        Task<T>UpdateAsync<T>(PlatformDTO platformDTO,string token);
        Task<T>DeleteAsync<T>(int id,string token);
    }
}
