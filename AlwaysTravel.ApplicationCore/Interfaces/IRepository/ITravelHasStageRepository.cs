using AlwaysTravel.DTO;

namespace AlwaysTravel.ApplicationCore.Interfaces.IRepository
{
    public interface ITravelHasStageRepository : IRepositoryBase<TravelHasStage, int>
    {
        IEnumerable<TravelHasStage> GetAllStageIdByTravelId(int travelId);

    }
}
