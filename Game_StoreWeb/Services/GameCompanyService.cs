using Game_StoreUtility;
using Game_StoreWeb.Models;
using Game_StoreWeb.Models.DTO;
using Game_StoreWeb.Services.IServices;

namespace Game_StoreWeb.Services
{
    public class GameCompanyService : BaseService, IGameCompanyService
    {
        private readonly IHttpClientFactory _clientFactory;
        private string gameStoreUrl;
        public GameCompanyService(IHttpClientFactory clientFactory,IConfiguration configuration):base(clientFactory)
        {
            _clientFactory = clientFactory;
            gameStoreUrl= configuration.GetValue<string>("ServiceUrls:GameStoreAPI");
        }
        public Task<T> CreateAsync<T>(GameCompanyCreateDTO gameCompanyCreateDTO, string token)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType=SD.ApiType.POST,
                Data = gameCompanyCreateDTO,
                Url=gameStoreUrl+ "/api/GameCompanyAPI",
                Token=token
            });
        }

        public Task<T> DeleteAsync<T>(int id, string token)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType=SD.ApiType.DELETE,
                Url=gameStoreUrl+ "/api/GameCompanyAPI/"+id,
                Token=token
            });
        }

        public Task<T> GetAllAsync<T>(string token)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = SD.ApiType.GET,
                Url=gameStoreUrl+ "/api/GameCompanyAPI",
                Token=token
            });
        }

        public Task<T> GetAsync<T>(int id, string token)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType=SD.ApiType.GET,
                Url=gameStoreUrl+ "/api/GameCompanyAPI/"+id,
                Token=token
            });
        }

        public Task<T> UpdateAsync<T>(GameCompanyDTO gameCompanyDTO, string token)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType=SD.ApiType.PUT,
                Data=gameCompanyDTO,
                Url=gameStoreUrl+ "/api/GameCompanyAPI/"+gameCompanyDTO.Id,
                Token=token
            });
        }
    }
}
