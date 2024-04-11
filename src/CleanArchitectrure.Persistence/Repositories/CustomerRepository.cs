using CleanArchitectrure.Application.Interface.Persistence;
using CleanArchitectrure.Domain.Entities;
using CleanArchitectrure.Persistence.Contexts;
using Dapper;
using System.Data;

namespace CleanArchitectrure.Persistence.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly DapperContext _applicationContext;

        public CustomerRepository(DapperContext applicationContext)
        {
            _applicationContext = applicationContext ?? throw new ArgumentNullException(nameof(applicationContext));
        }

        #region Queries
        /*Queries*/
        public async Task<int> CountAsync()
        {
            using var connection = _applicationContext.CreateConnection();
            var query = "Select Count(*) From Customers";

            var count = await connection.ExecuteScalarAsync<int>(query, commandType: CommandType.Text);
            return count;
        }

        public async Task<IEnumerable<Customer>> GetAllAsync()
        {
            using var connection = _applicationContext.CreateConnection();
            var query = "CustomersList";

            var customers = await connection.QueryAsync<Customer>(query, commandType: CommandType.StoredProcedure);
            return customers;
        }

        public async Task<IEnumerable<Customer>> GetAllWithPaginationAsync(int pageNumber, int pageSize)
        {
            using var connection = _applicationContext.CreateConnection();
            var query = "CustomersListWithPagination";

            var parameters = new DynamicParameters();
            parameters.Add("PageNumber", pageNumber);
            parameters.Add("PageSize", pageSize);

            var customers = await connection.QueryAsync<Customer>(query, param: parameters, commandType: CommandType.StoredProcedure);
            return customers;
        }

        public async Task<Customer> GetAsync(string id)
        {
            using var connection = _applicationContext.CreateConnection();
            var query = "CustomersGetByID";

            var parameters = new DynamicParameters();
            parameters.Add("CustomerID", id);

            var customers = await connection.QuerySingleOrDefaultAsync<Customer>(query, param: parameters, commandType: CommandType.StoredProcedure);
            return customers;
        }
        #endregion

        #region Commands
        /*Commands*/

        public async Task<bool> InsertAsync(Customer entity)
        {
            using var connection = _applicationContext.CreateConnection();
            var query = "CustomersInsert";

            var parameters = new DynamicParameters();
            parameters.Add("CustomerID", entity.CustomerId);
            parameters.Add("CompanyName", entity.CompanyName);
            parameters.Add("ContactName", entity.ContactName);
            parameters.Add("ContactTitle", entity.ContactTitle);
            parameters.Add("Address", entity.Address);
            parameters.Add("City", entity.City);
            parameters.Add("Region", entity.Region);
            parameters.Add("PostalCode", entity.PostalCode);
            parameters.Add("Country", entity.Country);
            parameters.Add("Phone", entity.Phone);
            parameters.Add("Fax", entity.Fax);

            var recordsAffected = await connection.ExecuteAsync(query, param: parameters, commandType: CommandType.StoredProcedure);
            return recordsAffected > 0;
        }

        public async Task<bool> UpdateAsync(Customer entity)
        {
            using var connection = _applicationContext.CreateConnection();
            var query = "CustomersUpdate";

            var parameters = new DynamicParameters();
            parameters.Add("CustomerID", entity.CustomerId);
            parameters.Add("CompanyName", entity.CompanyName);
            parameters.Add("ContactName", entity.ContactName);
            parameters.Add("ContactTitle", entity.ContactTitle);
            parameters.Add("Address", entity.Address);
            parameters.Add("City", entity.City);
            parameters.Add("Region", entity.Region);
            parameters.Add("PostalCode", entity.PostalCode);
            parameters.Add("Country", entity.Country);
            parameters.Add("Phone", entity.Phone);
            parameters.Add("Fax", entity.Fax);

            var recordsAffected = await connection.ExecuteAsync(query, param: parameters, commandType: CommandType.StoredProcedure);
            return recordsAffected > 0;
        }
        public async Task<bool> DeleteAsync(string id)
        {
            using var connection = _applicationContext.CreateConnection();
            var query = "CustomersDelete";


            var parameters = new DynamicParameters();
            parameters.Add("CustomerID", id);
            var recordsAffected = await connection.ExecuteAsync(query, param: parameters, commandType: CommandType.StoredProcedure);
            return recordsAffected > 0;
        }
        #endregion
    }
}
