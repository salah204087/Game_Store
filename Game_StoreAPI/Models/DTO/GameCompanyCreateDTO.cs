using System.ComponentModel.DataAnnotations;

namespace Game_StoreAPI.Models.DTO
{
    public class GameCompanyCreateDTO
    {
        [Required]
        [MaxLength(25)]
        public string? Name { get; set; }
        public string? ImageUrl { get; set; }
        public string? Details { get; set; }
        public string? EstablishmentDate { get; set; }
    }
}
