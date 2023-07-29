using Game_StoreUtility;
using Game_StoreWeb.Models;
using Game_StoreWeb.Models.DTO;
using Game_StoreWeb.Services.IServices;

namespace Game_StoreWeb.Services
{
    public class PlatformService : BaseService, IPlatformService
    {
        private readonly IHttpClientFactory _clientFactory;
        private string gameStoreUrl;
        public PlatformService(IHttpClientFactory clientFactory,IConfiguration configuration):base(clientFactory)
        {
            _clientFactory = clientFactory;
            gameStoreUrl = configuration.GetValue<string>("ServiceUrls:GameStoreAPI");
        }
        public Task<T> CreateAsync<T>(PlatformCreateDTO platformCreateDTO, string token)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = SD.ApiType.POST,
                Data = platformCreateDTO,
                Url = gameStoreUrl + "/api/PlatformAPI",
                Token = token
            });
        }

        public Task<T> DeleteAsync<T>(int id, string token)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType= SD.ApiType.DELETE,
                Url=gameStoreUrl+ "/api/PlatformAPI/"+id,
                Token = token
                
            });
        }

        public Task<T> GetAllAsync<T>(string token)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType=SD.ApiType.GET,
                Url=gameStoreUrl+ "/api/PlatformAPI",
                Token= token
            });
        }

        public Task<T> GetAsync<T>(int id, string token)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = SD.ApiType.GET,
                Url = gameStoreUrl + "/api/PlatformAPI/"+id,
                Token = token
            });
        }

        public Task<T> UpdateAsync<T>(PlatformDTO platformDTO, string token)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType=SD.ApiType.PUT,
                Data=platformDTO,
                Url=gameStoreUrl+ "/api/PlatformAPI/"+platformDTO.Id,
                Token=token
            });
        }
    }
}
