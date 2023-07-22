using Game_StoreAPI.Models;

namespace Game_StoreAPI.Repository.IRepository
{
    public interface IGameTypeRepository:IRepository<GameType>
    {
        GameType Update(GameType entity);
    }
}
