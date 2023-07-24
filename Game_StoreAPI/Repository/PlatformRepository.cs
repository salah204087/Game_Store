using Game_StoreAPI.Data;
using Game_StoreAPI.Models;
using Game_StoreAPI.Repository.IRepository;

namespace Game_StoreAPI.Repository
{
    public class PlatformRepository : Repository<Platform>, IPlatformRepository
    {
        private readonly ApplicationDbContext _context;
        public PlatformRepository(ApplicationDbContext context):base(context)
        {
            _context = context;
        }
        public Platform Update(Platform entity)
        {
            _context.Platforms.Update(entity);
            _context.SaveChanges();
            return entity;
        }
    }
}
