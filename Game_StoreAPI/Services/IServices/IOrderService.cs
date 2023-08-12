using Game_StoreAPI.Models;

namespace Game_StoreAPI.Services.IServices
{
    public interface IOrderService
    {
        void StoreOrder(List<ShoppingCartItem> items, string userId, string userEmailAddress);
        List<Order> GetOrdersByUserIdAndRole(string userId, string userRole);
    }
}
