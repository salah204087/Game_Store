using System.ComponentModel.DataAnnotations;

namespace Game_StoreAPI.Models
{
    public class Platform
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(25)]
        public string? Name { get; set; }
    }
}
