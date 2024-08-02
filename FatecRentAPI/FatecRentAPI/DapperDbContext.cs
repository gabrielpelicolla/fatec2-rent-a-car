using Microsoft.Data.SqlClient;
using System.Data;

namespace FatecRentAPI
{
    public class DapperDbContext : IDbContext
    {
        private readonly string? connectionString;

        public DapperDbContext(IConfiguration configuration)
        {
            connectionString = configuration.GetConnectionString("rentDb");
        }
        public IDbConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
