using Game_StoreAPI.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace Game_StoreWeb.Models.DTO
{
    public class OrderDTO
    {
        public int Id { get; set; }
        public string? UserName { get; set; }
        public string? UserId { get; set; }
        [ForeignKey(nameof(UserId))]
        public ApplicationUser? User { get; set; }
        public List<OrderItemDTO>? OrderItems { get; set; }
    }
}
