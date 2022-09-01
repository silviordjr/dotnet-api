using cars.Model;
using MySql.Data.MySqlClient;
using Dapper;

namespace cars.Repository
{
    public class CarsRepository : ICarsRepository
    {
        private readonly string _connectionString;
        public CarsRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IEnumerable<Cars> GetAll()
        {
            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                return connection.Query<Cars>("SELECT ID, Name, Price, Year, Sold FROM Cars ORDER BY Name ASC");
            }
        }
    }
}