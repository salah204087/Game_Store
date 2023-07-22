using System.Net;

namespace Game_StoreAPI.Models
{
    public class APIResponse
    {
        public APIResponse()
        {
            ErrorMessages = new List<string>();
        }
        public HttpStatusCode StatusCode { get; set; }
        public List<string>? ErrorMessages { get; set; }
        public bool IsSuccess { get; set; } = true;
        public object? Result { get; set; }
    }
}
