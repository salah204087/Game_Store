using Game_StoreWeb.Models.DTO;

namespace Game_StoreWeb.Services.IServices
{
    public interface IGameTypeService
    {
        Task<T> GetAllAsync<T>(string token);
        Task<T> GetAsync<T>(int id,string token);
        Task<T> CreateAsync<T>(GameTypeCreateDTO gameTypeCreateDTO,string token);
        Task<T> UpdateAsync<T>(GameTypeUpdateDTO gameTypeUpdateDTO,string token);
        Task<T> DeleteAsync<T>(int id, string token);
    }
}
