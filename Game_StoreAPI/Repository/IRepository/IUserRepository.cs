using Game_StoreAPI.Models.DTO;

namespace Game_StoreAPI.Repository.IRepository
{
    public interface IUserRepository
    {
        bool IsUniqueUser(string name);
        Task<LoginResponseDTO> Login(LoginRequestDTO loginRequestDTO);
        Task<UserDTO> Register(RegisterationRequestDTO registrationRequestDTO);
    }
}
