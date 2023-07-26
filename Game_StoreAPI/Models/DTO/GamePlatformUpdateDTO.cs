using System.ComponentModel.DataAnnotations;

namespace Game_StoreAPI.Models.DTO
{
    public class GamePlatformUpdateDTO
    {
        [Required]
        public int GameId { get; set; }
        [Required]
        public int PlatformId { get; set; }
    }
}
