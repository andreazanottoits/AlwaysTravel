using AlwaysTravel.ApplicationCore.Interfaces.IRepository;
using AlwaysTravel.ApplicationCore.Interfaces.IService;
using AlwaysTravel.DTO;

namespace AlwaysTravel.ApplicationCore.Services
{
    public class StageService : IStageService
    {
        private readonly IStageRepository _stageRepository;

        public StageService(IStageRepository stageRepository)
        {
            _stageRepository = stageRepository;
        }

        public long Count()
        {
            return _stageRepository.Count();
        }

        public void Delete(int id)
        {
            _stageRepository.Delete(id);
        }

        public Stage Get(int id)
        {
            return _stageRepository.Get(id);
        }

        public IEnumerable<Stage> GetAll()
        {
            return _stageRepository.GetAll();
        }

        public void Insert(Stage stage)
        {
            _stageRepository.Insert(stage);
        }

        public void Update(Stage stage)
        {
            _stageRepository.Update(stage);
        }
    }
}
