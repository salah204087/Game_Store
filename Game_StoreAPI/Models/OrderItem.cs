namespace Game_StoreAPI.Models
{
    public class OrderItem
    {
        public int Id { get; set; }
        public int Amount { get; set; }
        public double Price { get; set; }
        public int GameId { get; set; }
        public virtual Game? Game { get; set; }
        public int OrderId { get; set; }
        public virtual Order? Order { get; set; }
    }
}
