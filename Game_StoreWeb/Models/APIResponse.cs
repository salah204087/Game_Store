using System.Net;

namespace Game_StoreWeb.Models
{
    public class APIResponse
    {
        public bool IsSuccess { get; set; } = true;
        public HttpStatusCode StatusCode { get; set; }
        public List<string>? ErrorMessages { get; set; }
        public object? Result { get; set; }
    }
}
