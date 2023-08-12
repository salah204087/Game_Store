using System.ComponentModel.DataAnnotations.Schema;

namespace Game_StoreAPI.Models
{
    public class ShoppingCartItem
    {
        public int Id { get; set; }
        public int GameId { get; set; }
        public Game? Game { get; set; }
        public int Amount { get; set; }
        public string? ShoppingCartId { get; set; }
    }
}
