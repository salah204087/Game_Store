using Game_StoreWeb.Models.DTO;

namespace Game_StoreWeb.Services.IServices
{
    public interface IGameService
    {
        Task<T>GetAllAsync<T>(string token);
        Task<T>GetAsync<T>(int id,string token);
        Task<T>CreateAsync<T>(GameCreateDTO gameCreateDTO,string token);
        Task<T>UpdateAsync<T>(GameUpdateDTO gameUpdateDTO,string token);
        Task<T> DeleteAsync<T>(int id, string token);
    }
}
