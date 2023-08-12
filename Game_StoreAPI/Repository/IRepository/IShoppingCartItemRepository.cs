using Game_StoreAPI.Models;

namespace Game_StoreAPI.Repository.IRepository
{
    public interface IShoppingCartItemRepository:IRepository<ShoppingCartItem>
    {
        ShoppingCartItem Update(ShoppingCartItem entity);
    }
}
