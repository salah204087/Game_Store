using Game_StoreUtility;
using Game_StoreWeb.Models.DTO;
using Game_StoreWeb.Models;
using Game_StoreWeb.Services.IServices;

namespace Game_StoreWeb.Services
{
    public class AuthService:BaseService,IAuthService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private string gameStoreUrl;
        public AuthService(IHttpClientFactory httpClientFactory, IConfiguration configuration) : base(httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
            gameStoreUrl = configuration.GetValue<string>("ServiceUrls:GameStoreAPI");
        }
        public Task<T> LoginAsync<T>(LoginRequestDTO loginRequestDTO)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = SD.ApiType.POST,
                Data = loginRequestDTO,
                Url = gameStoreUrl + "/api/userAuth/login"
            });
        }

        public Task<T> RegisterAsync<T>(RegisetrationRequestDTO registerRequestDTO)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = SD.ApiType.POST,
                Data = registerRequestDTO,
                Url = gameStoreUrl + "/api/userAuth/register"
            });
        }
    }
}
