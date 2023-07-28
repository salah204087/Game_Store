using System.ComponentModel.DataAnnotations;

namespace Game_StoreWeb.Models.DTO
{
    public class GamePlatformCreateDTO
    {
        [Required]
        public int GameId { get; set; }
        [Required]
        public int PlatformId { get; set; }
    }
}
