using AlwaysTravel.ApplicationCore.Interfaces.IRepository;
using AlwaysTravel.ApplicationCore.Interfaces.IService;
using AlwaysTravel.DTO;

namespace AlwaysTravel.ApplicationCore.Services
{
    public class TravelHasStageService : ITravelHasStageService
    {
        private readonly ITravelHasStageRepository _travelHasStageRepository;

        public TravelHasStageService(ITravelHasStageRepository travelHasStageRepository)
        {
            _travelHasStageRepository = travelHasStageRepository;
        }

        public long Count()
        {
            return _travelHasStageRepository.Count();
        }

        public void Delete(int id)
        {
            _travelHasStageRepository.Delete(id);
        }

        public TravelHasStage Get(int id)
        {
            return _travelHasStageRepository.Get(id);
        }

        public IEnumerable<TravelHasStage> GetAll()
        {
            return _travelHasStageRepository.GetAll();
        }

        public IEnumerable<TravelHasStage> GetAllStageIdByTravelId(int travelId)
        {
            return _travelHasStageRepository.GetAllStageIdByTravelId(travelId);
        }

        public void Insert(TravelHasStage travelHasStage)
        {
            _travelHasStageRepository.Insert(travelHasStage);
        }

        public void Update(TravelHasStage travelHasStage)
        {
            _travelHasStageRepository.Update(travelHasStage);
        }
    }
}
