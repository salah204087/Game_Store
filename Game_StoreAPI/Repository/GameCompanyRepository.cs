using Game_StoreAPI.Data;
using Game_StoreAPI.Models;
using Game_StoreAPI.Repository.IRepository;

namespace Game_StoreAPI.Repository
{
    public class GameCompanyRepository : Repository<GameCompany>, IGameCompanyRepository
    {
        private readonly ApplicationDbContext _context;
        public GameCompanyRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public GameCompany Update(GameCompany entity)
        {
            _context.GameCompanies.Update(entity);
            _context.SaveChanges();
            return entity;
        }
    }
}
