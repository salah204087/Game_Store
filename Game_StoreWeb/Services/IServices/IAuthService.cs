using Game_StoreWeb.Models.DTO;

namespace Game_StoreWeb.Services.IServices
{
    public interface IAuthService
    {
        Task<T> LoginAsync<T>(LoginRequestDTO loginRequestDTO);
        Task<T> RegisterAsync<T>(RegisetrationRequestDTO registerRequestDTO);
    }
}
