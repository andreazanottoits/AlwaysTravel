using AlwaysTravel.ApplicationCore.Interfaces.IRepository;
using AlwaysTravel.ApplicationCore.Interfaces.IService;
using AlwaysTravel.DTO;

namespace AlwaysTravel.ApplicationCore.Services
{
    public class TravelService : ITravelService
    {
        private readonly ITravelRepository _travelRepository;
        private readonly ITravelHasStageService _travelHasStageService;
        private readonly IStageService _stageService;
        private readonly IPackageService _packageService;

        public TravelService(ITravelRepository travelRepository, ITravelHasStageService travelHasStageService, IStageService stageService, IPackageService packageService)
        {
            _travelRepository = travelRepository;
            _travelHasStageService = travelHasStageService;
            _stageService = stageService;
            _packageService = packageService;
        }

        public long Count()
        {
            return _travelRepository.Count();
        }

        public void Delete(int id)
        {
            _travelRepository.Delete(id);
        }

        public Travel Get(int id)
        {
            return _travelRepository.Get(id);
        }

        public IEnumerable<Travel> GetAll()
        {
            return _travelRepository.GetAll();
        }

        public List<StageData> GetAllTravelInformation(int id)
        {
            IEnumerable<TravelHasStage> travelHasStage = _travelHasStageService.GetAllStageIdByTravelId(id);

            List<StageData> stageData = new List<StageData>();
            foreach (var item in travelHasStage)
            {
                Stage stage = _stageService.Get(item.StageId);
                IEnumerable<Package> packages = _packageService.GetAllPackagesByStageId(item.StageId);

                stageData.Add(new StageData
                {
                    Stage = stage,
                    Packages = packages
                });
            }
            return stageData;
        }

        public void Insert(Travel travel)
        {
            _travelRepository.Insert(travel);
        }

        public void Update(Travel travel)
        {
            _travelRepository.Update(travel);
        }
    }
}
