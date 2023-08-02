using System.ComponentModel.DataAnnotations;

namespace Game_StoreAPI.Models.DTO
{
    public class GameCompanyCreateDTO
    {
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
