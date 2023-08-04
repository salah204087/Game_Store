using Microsoft.AspNetCore.Identity;

namespace Game_StoreAPI.Models
{
    public class ApplicationUser:IdentityUser
    {
        public string? Name { get; set; }
    }
}
