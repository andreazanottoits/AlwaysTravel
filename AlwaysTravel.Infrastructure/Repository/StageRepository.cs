using AlwaysTravel.ApplicationCore.Interfaces.IRepository;
using AlwaysTravel.DTO;
using Microsoft.Extensions.Configuration;
using RepoDb;
using Microsoft.Data.SqlClient;

namespace AlwaysTravel.Infrastructure.Repository
{
    public class StageRepository : IStageRepository
    {
        private readonly string _connectionString;

        public StageRepository(IConfiguration configuration)
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
            connection.Delete<Stage>(id);
        }

        public Stage Get(int id)
        {
            using var connection = new SqlConnection(_connectionString);
            return connection.Query<Stage>(id).FirstOrDefault();
        }

        public IEnumerable<Stage> GetAll()
        {
            using var connection = new SqlConnection(_connectionString);
            return connection.QueryAll<Stage>();
        }

        public void Insert(Stage entity)
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Insert<Stage>(entity);
        }

        public void Update(Stage entity)
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Update<Stage>(entity);
        }
    }
}
