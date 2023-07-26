using Game_StoreAPI.Models;

namespace Game_StoreAPI.Repository.IRepository
{
    public interface IGameRepository:IRepository<Game>
    {
        Game Update(Game entity);
    }
}
