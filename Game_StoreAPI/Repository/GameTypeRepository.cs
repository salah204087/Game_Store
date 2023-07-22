using Game_StoreAPI.Data;
using Game_StoreAPI.Models;
using Game_StoreAPI.Repository.IRepository;

namespace Game_StoreAPI.Repository
{
    public class GameTypeRepository : Repository<GameType>, IGameTypeRepository
    {
        private readonly ApplicationDbContext _context;
        public GameTypeRepository(ApplicationDbContext context):base(context)
        {
            _context = context;
        }
        public GameType Update(GameType entity)
        {
            entity.UpdatedDate = DateTime.Now;
            _context.GameTypes.Update(entity);
            _context.SaveChanges();
            return entity;
        }
    }
}
