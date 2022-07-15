using AlwaysTravel.DTO;

namespace AlwaysTravel.ApplicationCore.Interfaces.IService
{
    public interface ITravelService : IServiceBase<Travel, int>
    {
        List<StageData> GetAllTravelInformation(int id);
    }
}
