using Game_StoreUtility;
using Game_StoreWeb.Models;
using Game_StoreWeb.Models.DTO;
using Game_StoreWeb.Services.IServices;

namespace Game_StoreWeb.Services
{
    public class GameService : BaseService, IGameService
    {
        private readonly IHttpClientFactory _clientFactory;
        private string gameStoreUrl;
        public GameService(IHttpClientFactory clientFactory,IConfiguration configuration):base(clientFactory)
        {
            _clientFactory = clientFactory;
            gameStoreUrl = configuration.GetValue<string>("ServiceUrls:GameStoreAPI");
        }
        public Task<T> CreateAsync<T>(GameCreateDTO gameCreateDTO, string token)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType=SD.ApiType.POST,
                Data = gameCreateDTO,
                Url=gameStoreUrl+ "/api/GameAPI",
                Token=token
            });
        }

        public Task<T> DeleteAsync<T>(int id, string token)
        {
            return SendAsync<T>(new APIRequest() 
            { 
                ApiType=SD.ApiType.DELETE,
                Url=gameStoreUrl+ "/api/GameAPI/"+id,
                Token=token
            });
        }

        public Task<T> GetAllAsync<T>(string token)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType=SD.ApiType.GET,
                Url= gameStoreUrl + "/api/GameAPI",
                Token = token
            });
        }

        public Task<T> GetAsync<T>(int id, string token)
        {
            return SendAsync<T>(new APIRequest() {
                ApiType=SD.ApiType.GET,
                Url = gameStoreUrl + "/api/GameAPI/"+id,
                Token=token
            });
        }

        public Task<T> UpdateAsync<T>(GameUpdateDTO gameUpdateDTO, string token)
        {
            return SendAsync<T>(new APIRequest() {

                ApiType = SD.ApiType.PUT,
                Data=gameUpdateDTO,
                Url=gameStoreUrl+ "/api/GameAPI/"+gameUpdateDTO.Id,
                Token=token
            });
        }
    }
}
