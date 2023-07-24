using Game_StoreAPI.Models;

namespace Game_StoreAPI.Repository.IRepository
{
    public interface IPlatformRepository:IRepository<Platform>
    {
        Platform Update(Platform entity);
    }
}
