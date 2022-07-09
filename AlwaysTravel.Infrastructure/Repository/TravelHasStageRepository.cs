using AlwaysTravel.ApplicationCore.Interfaces.IRepository;
using AlwaysTravel.DTO;
using Microsoft.Extensions.Configuration;
using RepoDb;
using Microsoft.Data.SqlClient;

namespace AlwaysTravel.Infrastructure.Repository
{
    public class TravelHasStageRepository : ITravelHasStageRepository
    {
        private readonly string _connectionString;

        public TravelHasStageRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("dbConnection");

        }
        public long Count()
        {
            return GetAll().Count();
        }

        public void Delete(int id)
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Delete<TravelHasStage>(id);
        }

        public TravelHasStage Get(int id)
        {
            using var connection = new SqlConnection(_connectionString);
            return connection.Query<TravelHasStage>(id).FirstOrDefault();
        }

        public IEnumerable<TravelHasStage> GetAll()
        {
            using var connection = new SqlConnection(_connectionString);
            return connection.QueryAll<TravelHasStage>();
        }

        public IEnumerable<TravelHasStage> GetAllStageIdByTravelId(int travelId)
        {
            using var connection = new SqlConnection(_connectionString);
            return connection.Query<TravelHasStage>(travelHasStage => travelHasStage.TravelId == travelId);
        }

        public void Insert(TravelHasStage entity)
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Insert<TravelHasStage>(entity);
        }

        public void Update(TravelHasStage entity)
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Update<TravelHasStage>(entity);
        }
    }
}
