using Game_StoreWeb.Models.DTO;

namespace Game_StoreWeb.Services.IServices
{
    public interface IGameCompanyService
    {
        Task<T> GetAllAsync<T>(string token);
        Task<T> GetAsync<T>(int id,string token);
        Task<T> CreateAsync<T>(GameCompanyCreateDTO gameCompanyCreateDTO,string token);
        Task<T> UpdateAsync<T>(GameCompanyDTO gameCompanyDTO,string token);
        Task<T> DeleteAsync<T>(int id, string token);
    }
}
