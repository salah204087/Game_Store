using System.ComponentModel.DataAnnotations;

namespace Game_StoreWeb.Models.DTO
{
    public class GamePlatformUpdateDTO
    {
        [Required]
        public int GameId { get; set; }
        public GameDTO? Game { get; set; }
        [Required]
        public int PlatformId { get; set; }
        public PlatformDTO? Platform { get; set; }
    }
}
