using System.ComponentModel.DataAnnotations;

namespace Game_StoreAPI.Models.DTO
{
    public class GameTypeCreateDTO
    {
        [Required]
        [MaxLength(25)]
        public string? Name { get; set; }
        public string? About { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
