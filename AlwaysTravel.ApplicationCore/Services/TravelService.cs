using AlwaysTravel.ApplicationCore.Interfaces.IRepository;
using AlwaysTravel.ApplicationCore.Interfaces.IService;
using AlwaysTravel.DTO;

namespace AlwaysTravel.ApplicationCore.Services
{
    public class TravelService : ITravelService
    {
        private readonly ITravelRepository _travelRepository;

        public TravelService(ITravelRepository travelRepository)
        {
            _travelRepository = travelRepository;
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
