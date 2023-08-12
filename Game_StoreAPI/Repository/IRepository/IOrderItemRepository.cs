using Game_StoreAPI.Models;

namespace Game_StoreAPI.Repository.IRepository
{
    public interface IOrderItemRepository:IRepository<OrderItem>
    {
        OrderItem Update(OrderItem entity);
    }
}
