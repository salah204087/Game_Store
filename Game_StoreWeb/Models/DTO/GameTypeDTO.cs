using System.ComponentModel.DataAnnotations;

namespace Game_StoreWeb.Models.DTO
{
    public class GameTypeDTO
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(25)]
        public string? Name { get; set; }
        public string? About { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
