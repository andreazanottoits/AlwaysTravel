using AlwaysTravel.DTO;

namespace AlwaysTravel.ApplicationCore.Interfaces.IService
{
    public interface IServiceBase<TBaseEntity, TPrimaryKey>
        where TBaseEntity : BaseEntity<TPrimaryKey>
    {
        IEnumerable<TBaseEntity> GetAll();
        TBaseEntity Get(TPrimaryKey id);
        long Count();
        void Delete(TPrimaryKey id);
        void Insert(TBaseEntity user);
        void Update(TBaseEntity user);
    }
}
