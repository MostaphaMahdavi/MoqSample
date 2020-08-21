using System.Threading.Tasks;
using Mock.Domains.Commons;
using Mock.Domains.Commons.Enums;
using Mock.Domains.Customers.Entities;
using Mock.Domains.Customers.Repositories;

namespace Mock.DataLayerQueries.Repositories
{
    public class CustomerRepositoryQuery: ICustomerRepositoryQuery
    {

        public async Task<Customer> Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task IsValidCustomer(out bool result)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Customer> GetCustomer(int customerId, DbEngine dbEngine)
        {
            throw new System.NotImplementedException();
        }

        public Task<Customer> GetFromMongoDb(int customerId)
        {
            throw new System.NotImplementedException();
        }

        public Task<Customer> GetFromSqlServer(int customerId)
        {
            throw new System.NotImplementedException();
        }
    }
}