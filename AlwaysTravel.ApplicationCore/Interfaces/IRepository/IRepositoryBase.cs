using AlwaysTravel.DTO;

namespace AlwaysTravel.ApplicationCore.Interfaces.IRepository
{
    public interface IRepositoryBase<TBaseEntity, TPrimaryKey>
        where TBaseEntity : BaseEntity<TPrimaryKey>
    {
        IEnumerable<TBaseEntity> GetAll();
        TBaseEntity Get(TPrimaryKey id);
        void Insert(TBaseEntity entity);
        void Update(TBaseEntity entity);
        void Delete(TPrimaryKey id);
        long Count();
    }
}
