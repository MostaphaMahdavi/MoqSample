using System.Threading.Tasks;
using Mock.Domains.Customers.Entities;

namespace Mock.Domains.Customers.Repositories
{
    public interface ICustomerRepositoryQuery
    {
        Task<Customer> Get(int id);
        Task IsValidCustomer(out bool result);
    }
}