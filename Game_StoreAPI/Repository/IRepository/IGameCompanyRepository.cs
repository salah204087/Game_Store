using Game_StoreAPI.Models;

namespace Game_StoreAPI.Repository.IRepository
{
    public interface IGameCompanyRepository:IRepository<GameCompany>
    {
        GameCompany Update(GameCompany entity);
    }
}
