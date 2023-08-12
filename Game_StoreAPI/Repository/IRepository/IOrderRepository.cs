using Game_StoreAPI.Models;

namespace Game_StoreAPI.Repository.IRepository
{
    public interface IOrderRepository:IRepository<Order>
    {
        Order Update(Order entity);
    }
}
