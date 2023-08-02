using System.ComponentModel.DataAnnotations;

namespace Game_StoreWeb.Models.DTO
{
    public class GameCompanyDTO
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(25)]
        public string? Name { get; set; }
        [Required]
        public string? ImageUrl { get; set; }
        [Required]
        public string? Details { get; set; }
        [Required]
        public string? EstablishmentDate { get; set; }
    }
}
