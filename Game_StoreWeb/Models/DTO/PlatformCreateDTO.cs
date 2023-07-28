using System.ComponentModel.DataAnnotations;

namespace Game_StoreWeb.Models.DTO
{
    public class PlatformCreateDTO
    {
        [Required]
        [MaxLength(25)]
        public string? Name { get; set; }
    }
}
