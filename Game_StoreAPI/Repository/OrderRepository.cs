using Game_StoreAPI.Data;
using Game_StoreAPI.Models;
using Game_StoreAPI.Repository.IRepository;

namespace Game_StoreAPI.Repository
{
    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        private readonly ApplicationDbContext _context;
        public OrderRepository(ApplicationDbContext context):base(context)
        {
            _context = context;
        }
        public Order Update(Order entity)
        {
            _context.Orders.Update(entity);
            _context.SaveChanges();
            return entity;
        }
    }
}
