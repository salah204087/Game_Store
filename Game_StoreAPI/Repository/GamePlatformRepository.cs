using Game_StoreAPI.Data;
using Game_StoreAPI.Models;
using Game_StoreAPI.Repository.IRepository;

namespace Game_StoreAPI.Repository
{
    public class GamePlatformRepository : Repository<GamePlatform>, IGamePlatformRepository
    {
        private readonly ApplicationDbContext _context;
        public GamePlatformRepository(ApplicationDbContext context):base(context)
        {
            _context = context;
        }
        public GamePlatform Update(GamePlatform entity)
        {
            _context.GamePlatform.Update(entity);
            _context.SaveChanges();
            return entity;
        }
    }
}
