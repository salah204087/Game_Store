using static Game_StoreUtility.SD;

namespace Game_StoreWeb.Models
{
    public class APIRequest
    {
        public ApiType ApiType { get; set; } = ApiType.GET;
        public string? Url { get; set; }
        public object? Data { get; set; }
        public string? Token { get; set; }
    }
}
