using Game_StoreUtility;
using Game_StoreWeb.Models;
using Game_StoreWeb.Models.DTO;
using Game_StoreWeb.Services.IServices;

namespace Game_StoreWeb.Services
{
    public class GameTypeService : BaseService, IGameTypeService
    {
        private readonly IHttpClientFactory _clientFactory;
        private string gameStoreUrl;
        public GameTypeService(IHttpClientFactory clientFactory, IConfiguration configuration) : base(clientFactory)
        {
            _clientFactory = clientFactory;
            gameStoreUrl = configuration.GetValue<string>("ServiceUrls:GameStoreAPI");
        }
        public Task<T> CreateAsync<T>(GameTypeCreateDTO gameTypeCreateDTO, string token)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = SD.ApiType.POST,
                Data = gameTypeCreateDTO,
                Url = gameStoreUrl + "/api/GameTypeAPI",
                Token = token
            });
        }

        public Task<T> DeleteAsync<T>(int id, string token)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = SD.ApiType.DELETE,
                Url = gameStoreUrl + "/api/GameTypeAPI/" + id,
                Token = token
            });
        }

        public Task<T> GetAllAsync<T>(string token)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = SD.ApiType.GET,
                Url = gameStoreUrl + "/api/GameTypeAPI",
                Token = token
            });
        }

        public Task<T> GetAsync<T>(int id, string token)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = SD.ApiType.GET,
                Url = gameStoreUrl + "/api/GameTypeAPI/"+id,
                Token = token
            });
        }

        public Task<T> UpdateAsync<T>(GameTypeUpdateDTO gameTypeUpdateDTO, string token)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = SD.ApiType.PUT,
                Data = gameTypeUpdateDTO,
                Url = gameStoreUrl + "/api/GameTypeAPI/" + gameTypeUpdateDTO.Id,
                Token = token
            });
        }
    }
}
