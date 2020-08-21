using System.Threading.Tasks;
using Mock.Domains.Commons;
using Mock.Domains.Commons.Enums;
using Mock.Domains.Customers.Entities;

namespace Mock.Domains.Customers.Repositories
{
    public interface ICustomerRepositoryQuery
    {
        Task<Customer> Get(int id);
        Task IsValidCustomer(out bool result);
        Task<Customer> GetCustomer(int customerId,DbEngine dbEngine);
        Task<Customer> GetFromMongoDb(int customerId);
        Task<Customer> GetFromSqlServer(int customerId);

    }
}