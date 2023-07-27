using System.ComponentModel.DataAnnotations;

namespace Game_StoreAPI.Models.DTO
{
    public class GamePlatformUpdateDTO
    {
        [Required]
        public int GameId { get; set; }
        public Game? Game { get; set; }
        [Required]
        public int PlatformId { get; set; }
        public Platform? Platform { get; set; }
    }
}
