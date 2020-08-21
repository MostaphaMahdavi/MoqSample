using System.Threading.Tasks;

namespace Mock.Domains.Customers.Queries
{
    public interface IIsValidCustomerService
    {
        Task<bool> Execute(int customerId);
    }
}