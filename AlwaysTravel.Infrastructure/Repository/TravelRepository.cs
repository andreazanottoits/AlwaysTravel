using AlwaysTravel.ApplicationCore.Interfaces.IRepository;
using AlwaysTravel.DTO;
using Microsoft.Extensions.Configuration;
using RepoDb;
using Microsoft.Data.SqlClient;

namespace AlwaysTravel.Infrastructure.Repository
{
    public class TravelRepository : ITravelRepository
    {
        private readonly string _connectionString;

        public TravelRepository(IConfiguration configuration)
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
            connection.Delete<Travel>(id);
        }

        public Travel Get(int id)
        {
            using var connection = new SqlConnection(_connectionString);
            return connection.Query<Travel>(id).FirstOrDefault();
        }

        public IEnumerable<Travel> GetAll()
        {
            using var connection = new SqlConnection(_connectionString);
            List<OrderField> orderFields = new List<OrderField>();
            var orderBy = OrderField.Descending<Travel>(p => p.StartDate);
            orderFields.Add(orderBy);

            return connection.QueryAll<Travel>(orderBy: orderFields);
        }

        public void Insert(Travel entity)
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Insert<Travel>(entity);
        }

        public void Update(Travel entity)
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Update<Travel>(entity);
        }
    }
}
