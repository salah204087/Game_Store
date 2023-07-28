using System.ComponentModel.DataAnnotations;

namespace Game_StoreWeb.Models.DTO
{
    public class PlatformDTO
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(25)]
        public string? Name { get; set; }
        public List<GamePlatformDTO>? GamePlatform { get; set; }
    }
}
