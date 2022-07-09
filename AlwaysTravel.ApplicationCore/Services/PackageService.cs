using AlwaysTravel.ApplicationCore.Interfaces.IRepository;
using AlwaysTravel.ApplicationCore.Interfaces.IService;
using AlwaysTravel.DTO;

namespace AlwaysTravel.ApplicationCore.Services
{
    public class PackageService : IPackageService
    {
        private readonly IPackageRepository _packageRepository;

        public PackageService(IPackageRepository packageRepository)
        {
            _packageRepository = packageRepository;
        }

        public long Count()
        {
            return _packageRepository.Count();
        }

        public void Delete(int id)
        {
            _packageRepository.Delete(id);
        }

        public Package Get(int id)
        {
            return _packageRepository.Get(id);
        }

        public IEnumerable<Package> GetAll()
        {
            return _packageRepository.GetAll();
        }

        public IEnumerable<Package> GetAllPackagesByStageId(int stageId)
        {
            return _packageRepository.GetAllPackagesByStageId(stageId);
        }

        public void Insert(Package package)
        {
            _packageRepository.Insert(package);
        }

        public void Update(Package package)
        {
            _packageRepository.Update(package);
        }
    }
}
