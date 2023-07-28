﻿using Game_StoreUtility;
using Game_StoreWeb.Models;
using Game_StoreWeb.Services.IServices;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http.Headers;
using System.Text;

namespace Game_StoreWeb.Services
{
    public class BaseService : IBaseService
    {
        public APIResponse responseModel { get ; set ; }
        public IHttpClientFactory httpClient {  get; set ; }
        public BaseService(IHttpClientFactory httpClient)
        {
            this.responseModel = new APIResponse();
            this.httpClient = httpClient;
        }

        public async Task<T> SendAsync<T>(APIRequest apiRequest)
        {
            try
            {
                var client = httpClient.CreateClient("GameStoreAPI");
                HttpRequestMessage message = new HttpRequestMessage();
                message.Headers.Add("Accept", "application/json");
                message.RequestUri = new Uri(apiRequest.Url);
                if (apiRequest.Data!=null)
                {
                    message.Content=new StringContent(JsonConvert.SerializeObject(apiRequest.Data),
                        Encoding.UTF8,
                        "application/json");
                }
                switch(apiRequest.ApiType)
                {
                    case SD.ApiType.POST:
                        message.Method = HttpMethod.Post;
                        break;
                    case SD.ApiType.PUT:
                        message.Method = HttpMethod.Put;
                        break;
                    case SD.ApiType.DELETE:
                        message.Method = HttpMethod.Delete;
                        break;
                    default:
                        message.Method = HttpMethod.Get;
                        break;
                }
                HttpResponseMessage apiResponse = null;

                if (!string.IsNullOrEmpty(apiRequest.Token))
                {
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiRequest.Token);
                }

                apiResponse = await client.SendAsync(message);
                var apiContent = await apiResponse.Content.ReadAsStringAsync();

                try
                {
                    APIResponse ApiIResponse = JsonConvert.DeserializeObject<APIResponse>(apiContent);

                    if (apiResponse.StatusCode==HttpStatusCode.BadRequest||apiResponse.StatusCode==HttpStatusCode.NotFound)
                    {
                        ApiIResponse.StatusCode = HttpStatusCode.BadRequest;
                        ApiIResponse.IsSuccess = false;
                        var result = JsonConvert.SerializeObject(ApiIResponse);
                        var returnObject = JsonConvert.DeserializeObject<T>(result);
                        return returnObject;
                    }
                }catch(Exception ex)
                {
                    var exciptionResponse = JsonConvert.DeserializeObject<T>(apiContent);
                    return exciptionResponse;
                }
                var APIResponse = JsonConvert.DeserializeObject<T>(apiContent);
                return APIResponse;
            }catch(Exception ex) 
            {
                var dto = new APIResponse
                {
                    ErrorMessages = new List<string> { ex.ToString() },
                    IsSuccess = false
                };
                var result=JsonConvert.SerializeObject(dto);
                var APIResponse=JsonConvert.DeserializeObject<T>(result);

                return APIResponse;
            }
        }
    }
}
