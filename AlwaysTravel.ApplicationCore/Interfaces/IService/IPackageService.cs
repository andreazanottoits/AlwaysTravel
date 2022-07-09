using AlwaysTravel.DTO;

namespace AlwaysTravel.ApplicationCore.Interfaces.IService
{
    public interface IPackageService : IServiceBase<Package, int>
    {
        IEnumerable<Package> GetAllPackagesByStageId(int stageId);
    }
}
