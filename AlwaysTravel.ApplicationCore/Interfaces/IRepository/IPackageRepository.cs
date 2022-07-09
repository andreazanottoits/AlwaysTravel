using AlwaysTravel.DTO;

namespace AlwaysTravel.ApplicationCore.Interfaces.IRepository
{
    public interface IPackageRepository : IRepositoryBase<Package, int>
    {
        IEnumerable<Package> GetAllPackagesByStageId(int stageId);
    }
}
