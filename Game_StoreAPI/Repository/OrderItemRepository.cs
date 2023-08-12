using Game_StoreAPI.Data;
using Game_StoreAPI.Models;
using Game_StoreAPI.Repository.IRepository;

namespace Game_StoreAPI.Repository
{
    public class OrderItemRepository : Repository<OrderItem>, IOrderItemRepository
    {
        private readonly ApplicationDbContext _context;
        public OrderItemRepository(ApplicationDbContext context):base(context)
        {
            _context = context;
        }
        public OrderItem Update(OrderItem entity)
        {
           _context.OrderItems.Update(entity);
            _context.SaveChanges();
            return entity;
        }
    }
}
