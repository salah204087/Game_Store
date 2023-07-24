using System.ComponentModel.DataAnnotations;

namespace Game_StoreAPI.Models.DTO
{
    public class PlatformCreateDTO
    {
        [Required]
        [MaxLength(25)]
        public string? Name { get; set; }
    }
}
