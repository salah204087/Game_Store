using Game_StoreAPI.Data;
using Game_StoreAPI.Models;
using Game_StoreAPI.Repository.IRepository;

namespace Game_StoreAPI.Repository
{
    public class ShoppingcartItemRepository : Repository<ShoppingCartItem>, IShoppingCartItemRepository
    {
        private readonly ApplicationDbContext _context;
        public ShoppingcartItemRepository(ApplicationDbContext context):base(context)
        {
            _context = context;
        }
        public ShoppingCartItem Update(ShoppingCartItem entity)
        {
            _context.ShoppingCartItems.Update(entity);
            _context.SaveChanges();
            return entity;
        }
    }
}
