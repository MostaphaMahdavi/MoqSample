using System.Threading.Tasks;
using Mock.Domains.Commons;
using Mock.Domains.Commons.Enums;
using Mock.Domains.Customers.Entities;

namespace Mock.Domains.Customers.Queries
{
    public interface IGetCustomerDataService
    {
        Task<Customer> Execute(int customerId,DbEngine dbEngine);
    }
}