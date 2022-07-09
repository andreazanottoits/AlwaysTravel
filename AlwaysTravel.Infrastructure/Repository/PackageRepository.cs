using AlwaysTravel.ApplicationCore.Interfaces.IRepository;
using AlwaysTravel.DTO;
using Microsoft.Extensions.Configuration;
using RepoDb;
using Microsoft.Data.SqlClient;

namespace AlwaysTravel.Infrastructure.Repository
{
    public class PackageRepository : IPackageRepository
    {
        private readonly string _connectionString;

        public PackageRepository(IConfiguration configuration)
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
            connection.Delete<Package>(id);
        }

        public Package Get(int id)
        {
            using var connection = new SqlConnection(_connectionString);
            return connection.Query<Package>(id).FirstOrDefault();
        }

        public IEnumerable<Package> GetAll()
        {
            using var connection = new SqlConnection(_connectionString);
            return connection.QueryAll<Package>();
        }

        public IEnumerable<Package> GetAllPackagesByStageId(int stageId)
        {
            using var connection = new SqlConnection(_connectionString);
            return connection.Query<Package>(package => package.StageId == stageId);
        }

        public void Insert(Package entity)
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Insert<Package>(entity);
        }

        public void Update(Package entity)
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Update<Package>(entity);
        }
    }
}
