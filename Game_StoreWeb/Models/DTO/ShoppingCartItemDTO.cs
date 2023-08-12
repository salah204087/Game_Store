namespace Game_StoreWeb.Models.DTO
{
    public class ShoppingCartItemDTO
    {
        public int Id { get; set; }
        public GameDTO? Game { get; set; }
        public int Amount { get; set; }
        public string? ShoppingCartId { get; set; }
    }
}
