using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Game_StoreAPI.Models.DTO
{
    public class GameCreateDTO
    {
        [Required]
        [MaxLength(30)]
        public string? Name { get; set; }
        [Required]
        [MaxLength(255)]
        public string? Description { get; set; }
        [Required]
        [Range(0, 5)]
        public float Rate { get; set; }
        [Required]
        [Range(0, 100)]
        public int Quantity { get; set; }
        [Required]
        public float Price { get; set; }
        public DateTime AddedDate { get; set; }
        [Required]
        public DateTime UpdatedDate { get; set; }
        [Required]
        public string? ImageUrl { get; set; }
        [Required]
        public int GameTypeId { get; set; }
        [Required]
        public int GameCompanyId { get; set; }
        [Required]
        public List<int>? PlatformIds { get; set; }
    }
}
