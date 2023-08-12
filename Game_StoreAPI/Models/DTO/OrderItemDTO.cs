namespace Game_StoreAPI.Models.DTO
{
    public class OrderItemDTO
    {
        public int Id { get; set; }
        public int Amount { get; set; }
        public double Price { get; set; }
        public int GameId { get; set; }
        public virtual GameDTO? Game { get; set; }
        public int OrderId { get; set; }
        public virtual OrderDTO? Order { get; set; }
    }
}
