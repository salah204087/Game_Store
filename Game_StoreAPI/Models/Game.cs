using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Game_StoreAPI.Models
{
    public class Game
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string? Name { get; set; }
        [Required]
        [MaxLength(255)]
        public string? Description { get; set; }
        [Required]
        [Range(0,5)]
        public float Rate { get; set; }
        [Required]
        [Range (0,100)]
        public int Quantity { get; set; }
        [Required]
        public float Price { get; set; }
        public DateTime AddedDate { get; set; }
        [Required]
        public DateTime UpdatedDate { get; set; }
        [Required]
        public string? ImageUrl { get; set; }
        [ForeignKey("GameType")]
        public int GameTypeId { get; set; }
        public GameType? GameType { get; set; }
        [ForeignKey("GameCompany")]
        public int GameCompanyId { get; set; }
        public GameCompany? GameCompany { get; set; }
        public List<GamePlatform>? GamePlatform { get; set; }
    }
}
