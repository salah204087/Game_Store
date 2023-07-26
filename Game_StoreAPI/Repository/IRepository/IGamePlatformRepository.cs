using Game_StoreAPI.Models;

namespace Game_StoreAPI.Repository.IRepository
{
    public interface IGamePlatformRepository:IRepository<GamePlatform>
    {
        GamePlatform Update(GamePlatform entity);
    }
}
