using AlwaysTravel.DTO;

namespace AlwaysTravel.ApplicationCore.Interfaces.IService
{
    public interface ITravelHasStageService : IServiceBase<TravelHasStage, int>
    {
        IEnumerable<TravelHasStage> GetAllStageIdByTravelId(int travelId);

    }
}
