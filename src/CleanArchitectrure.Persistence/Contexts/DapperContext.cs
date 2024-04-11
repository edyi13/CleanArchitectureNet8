using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace CleanArchitectrure.Persistence.Contexts
{
    public class DapperContext
    {
        private readonly IConfiguration _configuration;
        private readonly string _connectionString;

        public DapperContext(IConfiguration configuration)
        {
            _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
            _connectionString = _configuration.GetConnectionString("NorthwindConnection") ?? throw new ArgumentNullException("Connection string not found.");
        }
        public IDbConnection CreateConnection() => new SqlConnection(_connectionString);
    }
}
