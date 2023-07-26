using Game_StoreAPI.Data;
using Game_StoreAPI.Models;
using Game_StoreAPI.Repository.IRepository;
using System.CodeDom;

namespace Game_StoreAPI.Repository
{
    public class GameRepository : Repository<Game>, IGameRepository
    {
        private readonly ApplicationDbContext _context;
        public GameRepository(ApplicationDbContext context):base(context)
        {
            _context = context;
        }

        public Game Update(Game entity)
        {
            entity.UpdatedDate = DateTime.Now;
            _context.Games.Update(entity);
            _context.SaveChanges();
            return entity;
        }
    }
}
